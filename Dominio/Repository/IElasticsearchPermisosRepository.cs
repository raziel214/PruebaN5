using ApiProducerN5.Models;
using Aplication.Dto.ElasticSearchDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repository
{
    public interface IElasticsearchPermisosRepository
    {
        Task<bool> RequestPermissionAsync(PermisosDTO permiso);
        Task<bool> ModifyPermissionAsync(Guid id, PermisosDTO permiso);
        Task<IEnumerable<PermisosDTO>> GetPermissionsAsync();


    }
}
