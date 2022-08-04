/* 
 * SaridaEdgeAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AnalysisApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AnalysisApiTests
    {
        private AnalysisApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnalysisApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalysisApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AnalysisApi
            //Assert.IsInstanceOfType(typeof(AnalysisApi), instance, "instance is a AnalysisApi");
        }

        /// <summary>
        /// Test AnalysisResultsCurrentGet
        /// </summary>
        [Test]
        public void AnalysisResultsCurrentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AnalysisResultsCurrentGet();
            //Assert.IsInstanceOf<AnalysisResult> (response, "response is AnalysisResult");
        }
        /// <summary>
        /// Test AnalysisResultsInspectionLogGet
        /// </summary>
        [Test]
        public void AnalysisResultsInspectionLogGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AnalysisResultsInspectionLogGet();
            //Assert.IsInstanceOf<AnalysisResults> (response, "response is AnalysisResults");
        }
    }

}