﻿using System;
using System.Collections.Generic;
using Worldsquare.Trulioo.Client.Model.Errors;

namespace Worldsquare.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Response object returned from Business Search containing metadata and results from search
    /// </summary>
    public class BusinessSearchResponse
    {
        /// <summary>
        ///     The id for the transaction it will be a GUID
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        ///     Time in UTC
        /// </summary>
        public DateTime UploadedDt { get; set; }

        /// <summary>
        ///     The country code for which the verification was performed.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        ///     Product Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        ///     RecordResult for the Business Search
        /// </summary>
        public BusinessRecord Record { get; set; }

        /// <summary>
        ///     Collection of record errors
        /// </summary>
        public List<ServiceError> Errors { get; set; }
    }
}