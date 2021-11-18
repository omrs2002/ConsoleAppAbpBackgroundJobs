using Abp.Application.Services;
using Abp.BackgroundJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbpBackgroundJobs
{
    public class RegistrationService : ApplicationService
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public RegistrationService(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public async Task RegisterAsync(string userName, string emailAddress, string password)
        {
            //TODO: Create new user in the database...

            await _backgroundJobManager
                .EnqueueAsync<AsyncBackgroundJob<EmailSendingArgs>, EmailSendingArgs>(
                new EmailSendingArgs
                {
                    EmailAddress = emailAddress,
                    Subject = "You've successfully registered!",
                    Body = "welocme!!"
                }
            );
        }
    }


}
