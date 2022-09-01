using DataModels;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new BbEastLiveDB())
            {
                var result = (from t in db.Users
                              join te in db.ApiOwners
                                     on t.ApiOwnerId equals te.Id
                              join us in db.UserSupermarkets on t.Id equals us.UserId
                              select new { t, te, us });

                // var apiowners = db.ApiOwners.Select(x => new { x.Id, x.Email, x.Username, x.Password, x.AccountId,x._3scaleUserId,x.ClientId,x.ClientSecret,x.Salt,x.CreatedAt,x.UpdatedAt,x.PasswordResetEmailSent,x.PasswordResetKey,x.StripeCustomerId,x.EmailVerificationKey,x.Organization,x.EnabledEmailMfa,x.MfaEmailLastCode, x.EnabledSmsMfa, x.MfaPhoneNumber,x.MfaSmsLastCode,x.EnabledGoogleMfa,x.MfaGoogleCode,x.InvalidLoginCount,x.LockedoutUntil,x.PwdResetTimestamp});

                foreach (var api in result)
                {   
                    Console.WriteLine(api.t.ApiOwnerId+" --- "+api.t.Email+" --- "+api.te.Id+ "  "+ api.te.Email+" --- "+ api.us.SupermarketId+"\n");
                }
            }

        }
    }
}
