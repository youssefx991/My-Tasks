using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entities
{
    public class EntityBase
    {
        public EntityState entityState {  get; set; } = EntityState.UnChanged;
    }
}
