using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankAccounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        // GET: api/<AccountsController>
        [HttpGet]
        public IEnumerable<string> GetAllAccounts()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("query/{id}")]
        public string GetAllAccountsQuery(
            [FromRoute] int id,
            [FromQuery] int[] aId)
        {
            if (aId.Length == 0)
            {
                return "Missing any aIDS";
            }

            return $"";

        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public string GetAccountById([FromRoute] int id)
        {
            return "value";
        }

        // POST api/<AccountsController>
        [HttpPost]
        public string CreateAccount([FromBody] string name)
        {
            return $"Account {name} created, ID: {Guid.NewGuid()}";
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public string UpdateAccountById([FromRoute] int id, [FromBody] string name)
        {
            return $"Account {id} updated to new name {name}";
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public string DeleteAccountById(int id)
        {
            return $"Account with ID {id} was deleted";
        }
    }
}
