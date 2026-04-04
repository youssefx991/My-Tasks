using BLL.Entities;
using BLL.EntitylLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks.Dataflow;
namespace BLL.EntityManagers
{
    public static class PublisherManager
    {
        public static DBManager DBManager = new();

        public static PublisherList SelectAllPublishers()
        {
            try
            {
                return DataTableToPublisherList(DBManager.ExecuteDataTable("SelectAllPublishers"));
            }
            catch
            {

            }

            return new();
        }


        internal static PublisherList DataTableToPublisherList(DataTable dt)
        {
            PublisherList publishers = new PublisherList();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    publishers.Add(DataRowToPublisher(item));
                }
            }
            catch
            {

            }
            return publishers;
        }

        internal static Publisher DataRowToPublisher(DataRow row)
        {
            Publisher P = new();
            try
            {
                P.pub_id = row["pub_id"].ToString() ?? string.Empty;
                P.pub_name = row["pub_name"].ToString() ?? string.Empty;
                P.city = row["city"].ToString() ?? string.Empty;
                P.state = row["state"].ToString() ?? string.Empty;
                P.country = row["country"].ToString() ?? string.Empty;
            }
            catch
            {

            }

            P.entityState = EntityState.UnChanged;
            return P;

        }
        public static bool UpdatePublisherName(string pub_id, string pub_name)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@pub_id"] = pub_id,
                    ["@pub_name"] = pub_name
                };
                return DBManager.ExecuteNonQuery("UpdatePublisherName", Parameters) > 0;

            }
            catch
            {

            }
            return false;
        }

        public static bool UpdatePublisherCity(string pub_id, string new_city)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@pub_id"] = pub_id,
                    ["@new_city"] = new_city
                };
                return DBManager.ExecuteNonQuery("UpdatePublisherCity", Parameters) > 0;
            }
            catch
            {
            }
            return false;
        }

        public static bool UpdatePublisherCountry(string pub_id, string new_country)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@pub_id"] = pub_id,
                    ["@new_country"] = new_country
                };
                return DBManager.ExecuteNonQuery("UpdatePublisherCountry", Parameters) > 0;
            }
            catch
            {
            }
            return false;
        }

        public static PublisherList SelectWithID(string pub_id)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@pub_id"] = pub_id
                };
                return DataTableToPublisherList(DBManager.ExecuteDataTable("SelectWithID", Parameters));
            }
            catch
            {
            }
            return new();

        }

        public static bool InsertPublisher(string pub_id, string pub_name, string city, string country)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@pub_id"] = pub_id,
                    ["@pub_name"] = pub_name,
                    ["@city"] = city,
                    ["@country"] = country
                };
                return DBManager.ExecuteNonQuery("InsertPublisher", Parameters) > 0;
            }
            catch
            {
            }
            return false;

        }

        public static bool DeletePublisher(string pub_id)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@pub_id"] = pub_id
                };
                return DBManager.ExecuteNonQuery("DeletePublisher", Parameters) > 0;
            }
            catch
            {
            }
            return false;
        }
    }
}

