﻿using Footban.Database.Account.Methods;
using Footban.Database.Account.Model.Request;
using Footban.Database.Account.Model.Response;
using System.Threading.Tasks;

namespace Footban.Database.Account
{
    public class AccountDataAccessLayer : IAccountDataAccessLayer
    {
        public async Task<HydratePlayerStateResponse> HydrateAsync(int playerId)
        {
            return await new Hydrate().ExecuteAsync(playerId);
        }

        public async Task<LogInResponse> LoginAsync(LogInRequest request)
        {
            return await new LogIn().ExecuteAsync(request);
        }
    }
}
