using System.ComponentModel.DataAnnotations;
using AutoMapper;
using CrediSoft.Application.DTOs;
using CrediSoft.Application.Interfaces;
using CrediSoft.Application.Validators.Clients;
using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Interfaces;

namespace CrediSoft.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> ChangeClientStatusAsync(int clientId, bool isActive)
        {
            var client = await _unitOfWork.Client.GetByIdAsync(clientId);

            if (client == null) return false;
            
            client.IsActive = isActive;

            await _unitOfWork.Client.UpdateAsync(client);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteClientAsync(int clientId)
        {
            var client = await _unitOfWork.Client.GetByIdAsync(clientId);
            
            if (client == null) return false;

            await _unitOfWork.BeginTransactionAsync();
            try
            {
                await _unitOfWork.Client.DeleteAsync(client);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitAsync();
                return true;
            }
            catch
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }

        }

        public async Task<IEnumerable<ClientDto>> GetActiveClientsAsync()
        {
            var clients = await _unitOfWork.Client.GetActiveClientsAsync();

            var result  = new List<ClientDto>();
            foreach (var client in clients)
            {
                result.Add( new ClientDto
                {
                    Id = client.Id,
                    FullName = client.FullName,
                    DocumentNumber = client.DocumentNumber,
                    IsActive = client.IsActive,
                    CreditLimit = client.CreditLimit
                });
            }

            return result; 
        }

        public async Task<IEnumerable<ClientDto>> GetAllClientsAsync()
        {
            var clients = await _unitOfWork.Client.GetAllAsync();

            return clients.Select(client => new ClientDto
            {
                Id = client.Id,
                FullName = client.FullName,
                DocumentNumber = client.DocumentNumber,
                IsActive = client.IsActive,
                CreditLimit = client.CreditLimit
            }).ToList();
        }

        public async Task<ClientDto?> GetClientByIdAsync(int clientId)
        {
            var client = await _unitOfWork.Client.GetByIdAsync(clientId);

            if (client == null) return null;

            var clientDto = _mapper.Map<ClientDto>(client);

            return clientDto;
        }

        public Task<ClientDto?> GetClientByDocumentAsync(string document)
        {
            throw new NotImplementedException();
        }

        public async Task CreateClientAsync(CreateClientDto clientDto)
        {
            var validator = new CreateClientValidator();
            var validationResult = validator.Validate(clientDto);

            if (!validationResult.IsValid)
            {
                var errors = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new ValidationException(errors);
            }
            
            var client = _mapper.Map<Client>(clientDto);

            await _unitOfWork.BeginTransactionAsync();
            try
            {
                await _unitOfWork.Client.AddAsync(client);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitAsync();

            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw; 
            }
        }

        public async Task<bool> UpdateClientAsync(int clientId, UpdateClientDto clientDto)
        {
            if (clientDto == null)
                throw new ArgumentNullException(nameof(clientDto));

            var client = await _unitOfWork.Client.GetByIdAsync(clientId);

            
            if (client == null) return false;

            _mapper.Map(clientDto, client);

            await _unitOfWork.BeginTransactionAsync();
            try
            {
                await _unitOfWork.Client.UpdateAsync(client);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitAsync();
                return true;
            }
            catch
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public Task<bool> ValidateCreditHistoryAsync(string identification)
        {
            throw new NotImplementedException();
        }
    }
}
