﻿//---------------------------------------------------------------------
// <copyright file="ICodeGenerationVerifier.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.Test.Taupo.Astoria.Contracts
{
    using System.Collections.ObjectModel;
    using System.Reflection;
    using Microsoft.Test.Taupo.Common;
    using Microsoft.Test.Taupo.Contracts.EntityModel;

    /// <summary>
    /// Interface allows for a test to request an authentication provider which it can use to authenticate against
    /// a Data Service
    /// </summary>
    [ImplementationSelector("CodeGenVerifier", DefaultImplementation = "Default", HelpText = "The verifier to use when verifying code generated by the codegen utility")]
    public interface ICodeGenerationVerifier
    {
        /// <summary>
        /// Verifies code generated by the product's code generation utility
        /// </summary>
        /// <param name="model">The conceptual model for the data service the codegen utility is targetting</param>
        /// <param name="clientTypesAssembly">The assembly produced by compiling the source generated by DataSvcUtil</param>
        /// <param name="isDataServiceCollection">A boolean flag indicating whether the /DataServiceCollection switch was passed in to the codegen utility</param>
        /// <returns>The validation errors as a result of the verification</returns>
        ReadOnlyCollection<string> VerifyGeneratedCode(EntityModelSchema model, Assembly clientTypesAssembly, bool isDataServiceCollection);
    }
}