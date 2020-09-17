using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WAppDomBase.Bases.Serialize;

namespace WAppDom.Actions
{
    public class JsnDesActions : JsnDesBase
    {
        public JsnDesActions()
        {
            try
            {
                dsopts = DesOpts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private JsonSerializerOptions dsopts;


        public override async Task<T> Deserialize<T>(Stream stream)
        {
            try
            {
                T obj = await JsonSerializer.DeserializeAsync<T>(stream, dsopts);

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override T Deserialize<T>(string str)
        {
            try
            {
                T obj = JsonSerializer.Deserialize<T>(str, dsopts);

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private JsonSerializerOptions DesOpts()
        {
            try
            {
                var opts = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    ReferenceHandler = ReferenceHandler.Preserve
                };
                opts.Converters.Add(new JsonStringEnumConverter());

                return opts;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
