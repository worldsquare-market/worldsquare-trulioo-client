using System.Collections.Generic;
using Worldsquare.Trulioo.Client.Model.Errors;

namespace Worldsquare.Trulioo.Client.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Record
    {
        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming Not our code
        public string TransactionRecordID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecordStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<DatasourceResult> DatasourceResults { get; set; }

        /// <summary>
        ///<ul>
        ///<li>1002 : Datasource Unavailable - The source did not respond</li>
        ///<li>1006 : Unrecognized Field Name</li>
        ///<li>1007 : Consent datasource not recognized</li>
        ///<li>1008 : Invalid Field Format</li>
        ///<li>1009 : Unrecognized Field group</li>
        ///<li>1010 : Request Timed Out</li>
        ///<li>1011 : Duplicate Field received</li>
        ///<li>2000 : Unrecognized Error</li>
        ///</ul>
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RecordRule Rule { get; set; }
    }
}
