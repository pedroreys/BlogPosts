using System.Web.Mvc;

namespace ContentType.Controllers
{
    public class ClientController : ContentTypeAwareController 
    {
    	public ActionResult Index()
        {
            var clientes = new[]
                               {
                                   new Cliente {FirstName = "John", LastName = "Smith"},
                                   new Cliente {FirstName = "Dave", LastName = "Boo"},
                                   new Cliente {FirstName = "Garry", LastName = "Foo"}
                               };

            return ResultWith(clientes);
        }

    }

    public class Cliente
    {
        public string FirstName{get;set;}

        public string LastName{get; set; }
        
    }
}
