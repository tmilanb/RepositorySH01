using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("H");

            string valueAcc = "sel06528";


            using (var context = new PrincipalContext(ContextType.Domain, "AD005"))
            {
                var user = UserPrincipal.FindByIdentity(context, value);

                ////Find the City
                DirectoryEntry entry = new DirectoryEntry("AD005");
                entry.Path = "LDAP://DC = ad005,DC = onehc,DC = net";
                DirectorySearcher dSearch = new DirectorySearcher(entry);

                dSearch.Filter = "(&(objectClass=user)(samAccountName=" + valueAcc + "))";
                dSearch.PropertiesToLoad.Add("l");
                dSearch.PropertiesToLoad.Add("siemens-gid");

                SearchResult result = dSearch.FindOne();

                string location = result.Properties["l"][0].ToString();
                string siemensTwo = result.Properties["siemens-gid"][0].ToString();
                Console.WriteLine(location.ToString());
                Console.WriteLine("A siemens-gid is the following: " + siemensTwo.ToString());
            }

            

            Console.ReadLine();

        }
    }
}
