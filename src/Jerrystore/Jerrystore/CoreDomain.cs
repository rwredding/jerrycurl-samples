using System;
using Jerrycurl.Mvc;

namespace Jerrystore
{
    public class CoreDomain : IDomain
    {
        public void Configure(DomainOptions options)
        {
            options.UseSqlServer("SERVER=.;DATABASE=jerrystore;TRUSTED_CONNECTION=true");
        }
    }
}