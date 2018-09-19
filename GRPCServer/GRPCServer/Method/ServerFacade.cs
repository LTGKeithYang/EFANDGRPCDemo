using Grpc.Core;
using GrpcServer;
using GRPCServer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace GRPCServer.Method
{
    class ServerFacade: TestEF.TestEFBase
    {
        public override Task<AddUserResponse> AddUsers(AddUserRequest request, ServerCallContext context)
        {
            var result = new AddUserResponse();

            using (var db = new EFContext())
            {
                db.Users.Add(new Users { UserName = "Keith", Password = "1234" });
                db.Users.Add(new Users { UserName = "Apple", Password = "1234" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                foreach (var user in db.Users)
                {
                    Console.WriteLine(" - {0}", user.UserName);
                }
                result.UserName = db.Users.FirstOrDefault().UserName;
                result.PassWord = db.Users.FirstOrDefault().Password;
                return Task.FromResult(result);
            }
        }
    }
}
