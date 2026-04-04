using BLL.Entities;
using BLL.EntitylLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL.EntityManagers
{
    public class TitleManager
    {
        public static DBManager DBManager = new();

        public static TitleList SelectAllTitles()
        {
            try
            {
                return DataTableToTitleList(DBManager.ExecuteDataTable("SelectAllTitles"));
            }
            catch
            {

            }

            return new();
        }

        internal static TitleList DataTableToTitleList(DataTable dt)
        {
            TitleList titles = new TitleList();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    titles.Add(DataRowToTitle(item));
                }
            }
            catch
            {

            }
            return titles;
        }

        internal static Title DataRowToTitle(DataRow row)
        {
            Title T = new();
            try
            {

                T.title_id = row["title_id"]?.ToString() ?? "N/A";
                T.title = row["title"]?.ToString() ?? "N/A";
                T.type = row["type"]?.ToString() ?? "N/A";
                T.pub_id = row["pub_id"]?.ToString() ?? "N/A";
                if (decimal.TryParse(row["price"]?.ToString(), out decimal price))
                    T.price = price;
                else
                    T.price = null;

                if (decimal.TryParse(row["advance"]?.ToString(), out decimal advance))
                    T.advance = advance;
                else
                    T.advance = null;

                if (int.TryParse(row["royalty"]?.ToString(), out int royalty))
                    T.royalty = royalty;
                else
                    T.royalty = null;

                if (int.TryParse(row["ytd_sales"]?.ToString(), out int ytd_sales) && ytd_sales > 0)
                    T.ytd_sales = ytd_sales;
                else
                    T.ytd_sales = null;

                T.notes = row["notes"]?.ToString() ?? "N/A";
                T.pubdate = row.Field<DateTime?>("pubdate") ?? DateTime.MinValue;

            }
            catch
            {

            }
            T.entityState = EntityState.UnChanged;
            return T;
        }

        
        public static bool UpdateTitle(Title t)
        {

            var pararmeters = new Dictionary<string, object>()
            {
                ["@title_id"] = t.title_id,
                ["@new_title"] = t.title,
                ["@new_type"] = t.type,
                ["@new_pub_id"] = t.pub_id,
                ["@new_price"] = t.price ?? (object)DBNull.Value,
                ["@new_advance"] = t.advance ?? (object)DBNull.Value,
                ["@new_royalty"] = t.royalty ?? (object)DBNull.Value,
                ["@new_ytd_sales"] = t.ytd_sales ?? (object)DBNull.Value,
                ["@new_notes"] = t.notes ?? (object)DBNull.Value,
                ["@new_pubdate"] = t.pubdate
            };

            return DBManager.ExecuteNonQuery("UpdateTitle", pararmeters) > 0;


        }

        public static bool InsertTitle(Title t)
        {
            var pararmeters = new Dictionary<string, object>()
            {
                ["@title_id"] = t.title_id,
                ["@title"] = t.title,
                ["@type"] = t.type,
                ["@pub_id"] = t.pub_id,
                ["@price"] = t.price ?? (object)DBNull.Value,
                ["@advance"] = t.advance ?? (object)DBNull.Value,
                ["@royalty"] = t.royalty ?? (object)DBNull.Value,
                ["@ytd_sales"] = t.ytd_sales ?? (object)DBNull.Value,
                ["@notes"] = t.notes ?? (object)DBNull.Value,
                ["@pubdate"] = t.pubdate
            };
            return DBManager.ExecuteNonQuery("InsertTitle", pararmeters) > 0;
        }
        public static bool DeleteTitle(Title t)
        {
            var pararmeters = new Dictionary<string, object>()
            {
                ["@title_id"] = t.title_id
            };
            return DBManager.ExecuteNonQuery("DeleteTitle", pararmeters) > 0;
        }
    }
}
