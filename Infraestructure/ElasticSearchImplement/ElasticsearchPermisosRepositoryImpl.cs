

using Aplication.Dto.ElasticSearchDtos;
using Dominio.Repository;
using Nest;
using System.Collections;

namespace Infraestructure.ElasticSearchImplement
{
    public class ElasticsearchPermisosRepositoryImpl: IElasticsearchPermisosRepository
    {
        private readonly IElasticClient _elasticClient;

        public ElasticsearchPermisosRepositoryImpl(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<IEnumerable<PermisosDTO>> GetPermissionsAsync()
        {
            // Crea una consulta vacía, similar a un "getAll"
            var searchDescriptor = new SearchDescriptor<PermisosDTO>();

            // Ejecuta la búsqueda en Elasticsearch
            var searchResponse = await _elasticClient.SearchAsync<PermisosDTO>(searchDescriptor);

            // Crea una lista vacía para almacenar los PermisosDTO mapeados
            var permisos = new List<PermisosDTO>();

            // Recorre los resultados y mapea los datos
            foreach (var hit in searchResponse.Hits)
            {
                // Crea un nuevo PermisosDTO y mapea los datos del documento
                var permisoDTO = new PermisosDTO
                {
                    Id = hit.Source.Id,
                    Nombre = hit.Source.Nombre,
                    Descripcion = hit.Source.Descripcion,
                    FechaInicio = hit.Source.FechaInicio,
                    FechaFin = hit.Source.FechaFin,
                    // Agrega propiedades adicionales según la estructura de tus DTOs
                };

                permisos.Add(permisoDTO);
            }

            // Devuelve la lista de PermisosDTO mapeados
            return permisos;
        }



        public async Task<bool> ModifyPermissionAsync(Guid id, PermisosDTO permiso)
        {
            var response = await _elasticClient.UpdateAsync<PermisosDTO>(id, u => u.Doc(permiso));
            return response.IsValid;
        }




        public async Task<bool> RequestPermissionAsync(PermisosDTO permiso)
        {
            try
            {
                var response = await _elasticClient.IndexDocumentAsync(permiso);
                return response.IsValid;
            }
            catch (Exception ex)
            {
                // Maneja la excepción de forma adecuada
                throw ex; // O registra el error y devuelve false
            }
        }

    }
}
