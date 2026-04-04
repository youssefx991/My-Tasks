using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entities
{
    public class Publisher : EntityBase
    {
        /*
         CREATE TABLE [dbo].[publishers](
	    [pub_id] [char](4) NOT NULL,
	    [pub_name] [varchar](40) NULL,
	    [city] [varchar](20) NULL,
	    [state] [char](2) NULL,
	    [country] [varchar](30) NULL, 
         */

        public string pub_id
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (entityState != EntityState.Added)
                        this.entityState = EntityState.Modified;
                }
            }
        }


        public string? pub_name
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (entityState != EntityState.Added)
                        this.entityState = EntityState.Modified;
                }
            }
        }
        public string? city
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (entityState != EntityState.Added)
                        this.entityState = EntityState.Modified;
                }
            }
        }
        public string? state
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (entityState != EntityState.Added)
                        this.entityState = EntityState.Modified;
                }
            }
        }
        public string? country
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (entityState != EntityState.Added)
                        this.entityState = EntityState.Modified;
                }
            }
        }

        public Publisher()
        {
            this.entityState = EntityState.Added;
        }

    }
}
