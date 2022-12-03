using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGO_PROJECT.CDatos
{
    internal class CDLote
    {
        public bool insertarLote(Lote p_lote)
        {
            VIKINGO db = new VIKINGO();
            try
            {
                db.Lote.Add(p_lote);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
