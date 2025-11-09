using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrediSoft.Application.DTOs;

namespace CrediSoft.Application.Interfaces
{
    public interface IClientService
    {
        Task CreateClientAsync(CreateClientDto clientDto);
        Task<bool> UpdateClientAsync(int clientId, UpdateClientDto clientDto);
        Task<ClientDto?> GetClientByIdAsync(int clientId);
        Task<ClientDto?> GetClientByDocumentAsync(string identification);
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();
        Task<IEnumerable<ClientDto>> GetActiveClientsAsync();
        Task<bool> ChangeClientStatusAsync(int clientId, bool isActive);
        Task<bool> DeleteClientAsync(int clientId);
    }
}
