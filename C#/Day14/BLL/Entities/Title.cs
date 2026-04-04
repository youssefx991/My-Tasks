using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entities
{
    public class Title : EntityBase
    {
        /*
         CREATE TABLE [dbo].[titles](
		[title_id] [dbo].[tid] NOT NULL,
		[title] [varchar](80) NOT NULL,
		[type] [char](12) NOT NULL,
		[pub_id] [char](4) NULL,
		[price] [money] NULL,
		[advance] [money] NULL,
		[royalty] [int] NULL,
		[ytd_sales] [int] NULL,
		[notes] [varchar](200) NULL,
		[pubdate] [datetime] NOT NULL, 
         */

        public string title_id
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

        public string title
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
        public string type
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
        public string? pub_id
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
        public decimal? price
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
        public decimal? advance
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
        public int? royalty
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
        public int? ytd_sales
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
        public string? notes
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
        public DateTime pubdate
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

        public Title()
        {
            this.entityState = EntityState.Added;
        }


    }
}
