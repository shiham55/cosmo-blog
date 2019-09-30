using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ComoBlog.Data.Base
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
