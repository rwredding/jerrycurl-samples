using System;
using Jerrycurl.Mvc;

namespace MovieDb.Data
{
    public class CoreDomain : IDomain
    {
        public void Configure(DomainOptions options)
        {
            options.UseSqlServer("SERVER=.;DATABASE=movie_db;TRUSTED_CONNECTION=true");
        }
    }
}