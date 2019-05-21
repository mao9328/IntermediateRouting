using DemoCal.IntermediateRouting.Models;
using IntermediateRouting.Repository;
using System.Linq;

namespace IntermediateRouting.Logic
{
    public class RouterLogic
    {
        private readonly DbManager _dataAccessProvider;

        public RouterLogic(DbManager context)
        {
            _dataAccessProvider = context;
        }

        public MultipleRouteOperationNumeroReferenciaGet GetProviderByReferenceAndOperation(string reference, string operation)
        {
            try
            {
                using (var context = _dataAccessProvider)
                {
                    Routing result = context.Providers
                        .Where(x => reference.Substring(0, 4).Equals(x.Identifier) && x.Provider.Equals(operation))
                        .Select(x => new Routing()
                        {
                            Action = x.Action,
                            Endpoint = x.Endpoint,
                            Identifier = x.Identifier,
                            Provider = x.Provider,
                            Type = (Type)x.Type,
                            XSLTRequest = x.XSLTRequest,
                            XSLTResponse = x.XSLTResponse
                        }).FirstOrDefault();

                    return new MultipleRouteOperationNumeroReferenciaGet()
                    {
                        Resultado = new Resultado()
                        {
                            Descripcion = "Ok"
                        },
                        Routing = result
                    };
                }
            }
            catch (System.Exception e)
            {
                return new MultipleRouteOperationNumeroReferenciaGet()
                {
                    Resultado = new Resultado()
                    {
                        Descripcion = $"{e.Message}{e.InnerException?.Message}"
                    },
                    Routing = null
                };
            }
        }
    }
}
