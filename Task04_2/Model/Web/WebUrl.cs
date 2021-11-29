using System;
using System.Collections.Generic;
using System.Net;

namespace Task04_2.Model.Web
{
    public class WebUrl
    {
        public string Host { get; }
        public string Path { get; }
        public string Query { get; }

        public WebUrl(string host, string path = "", string query = "") => (Host, Path, Query) = (host, path, query);

        public WebUrl(string host, string path = "", Dictionary<string, string> queries = null)
        {
            Host = host;
            Path = path;
            Query = ConvertQueriesToString(queries);
        }

        public string CreateUrl()
        {
            return Host +
                   (!string.IsNullOrWhiteSpace(Path) ? Path : "") +
                   (!string.IsNullOrWhiteSpace(Query) ? "?" + Query : "");
        }

        private string ConvertQueriesToString(Dictionary<string, string> queries)
        {
            string query = "";

            if (queries.Count > 0)
            {
                foreach (KeyValuePair<string, string> queryKeyValue in queries)
                {
                    query += String.IsNullOrEmpty(query) ? "" : "&";
                    query += queryKeyValue.Key + "=" + WebUtility.UrlEncode(queryKeyValue.Value);
                }
            }

            return query;
        }
    }
}