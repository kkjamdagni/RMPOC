using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoDBTestProject
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_InsertASIAMLoginTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_InsertGHRMLoginTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_InsertWBEGLoginTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_ProcessASIAMLoginTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_ProcessGHRMLoginTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_ProcessWBEGLoginTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition6;
            this.dbo_InsertASIAMLoginTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_InsertGHRMLoginTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_InsertWBEGLoginTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_ProcessASIAMLoginTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_ProcessGHRMLoginTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_ProcessWBEGLoginTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_InsertASIAMLoginTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_InsertGHRMLoginTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_InsertWBEGLoginTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_ProcessASIAMLoginTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_ProcessGHRMLoginTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_ProcessWBEGLoginTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // dbo_InsertASIAMLoginTestData
            // 
            this.dbo_InsertASIAMLoginTestData.PosttestAction = null;
            this.dbo_InsertASIAMLoginTestData.PretestAction = null;
            this.dbo_InsertASIAMLoginTestData.TestAction = dbo_InsertASIAMLoginTest_TestAction;
            // 
            // dbo_InsertASIAMLoginTest_TestAction
            // 
            dbo_InsertASIAMLoginTest_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(dbo_InsertASIAMLoginTest_TestAction, "dbo_InsertASIAMLoginTest_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // dbo_InsertGHRMLoginTestData
            // 
            this.dbo_InsertGHRMLoginTestData.PosttestAction = null;
            this.dbo_InsertGHRMLoginTestData.PretestAction = null;
            this.dbo_InsertGHRMLoginTestData.TestAction = dbo_InsertGHRMLoginTest_TestAction;
            // 
            // dbo_InsertGHRMLoginTest_TestAction
            // 
            dbo_InsertGHRMLoginTest_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(dbo_InsertGHRMLoginTest_TestAction, "dbo_InsertGHRMLoginTest_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // dbo_InsertWBEGLoginTestData
            // 
            this.dbo_InsertWBEGLoginTestData.PosttestAction = null;
            this.dbo_InsertWBEGLoginTestData.PretestAction = null;
            this.dbo_InsertWBEGLoginTestData.TestAction = dbo_InsertWBEGLoginTest_TestAction;
            // 
            // dbo_InsertWBEGLoginTest_TestAction
            // 
            dbo_InsertWBEGLoginTest_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(dbo_InsertWBEGLoginTest_TestAction, "dbo_InsertWBEGLoginTest_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // dbo_ProcessASIAMLoginTestData
            // 
            this.dbo_ProcessASIAMLoginTestData.PosttestAction = null;
            this.dbo_ProcessASIAMLoginTestData.PretestAction = null;
            this.dbo_ProcessASIAMLoginTestData.TestAction = dbo_ProcessASIAMLoginTest_TestAction;
            // 
            // dbo_ProcessASIAMLoginTest_TestAction
            // 
            dbo_ProcessASIAMLoginTest_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(dbo_ProcessASIAMLoginTest_TestAction, "dbo_ProcessASIAMLoginTest_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // dbo_ProcessGHRMLoginTestData
            // 
            this.dbo_ProcessGHRMLoginTestData.PosttestAction = null;
            this.dbo_ProcessGHRMLoginTestData.PretestAction = null;
            this.dbo_ProcessGHRMLoginTestData.TestAction = dbo_ProcessGHRMLoginTest_TestAction;
            // 
            // dbo_ProcessGHRMLoginTest_TestAction
            // 
            dbo_ProcessGHRMLoginTest_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(dbo_ProcessGHRMLoginTest_TestAction, "dbo_ProcessGHRMLoginTest_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // dbo_ProcessWBEGLoginTestData
            // 
            this.dbo_ProcessWBEGLoginTestData.PosttestAction = null;
            this.dbo_ProcessWBEGLoginTestData.PretestAction = null;
            this.dbo_ProcessWBEGLoginTestData.TestAction = dbo_ProcessWBEGLoginTest_TestAction;
            // 
            // dbo_ProcessWBEGLoginTest_TestAction
            // 
            dbo_ProcessWBEGLoginTest_TestAction.Conditions.Add(inconclusiveCondition6);
            resources.ApplyResources(dbo_ProcessWBEGLoginTest_TestAction, "dbo_ProcessWBEGLoginTest_TestAction");
            // 
            // inconclusiveCondition6
            // 
            inconclusiveCondition6.Enabled = true;
            inconclusiveCondition6.Name = "inconclusiveCondition6";
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_InsertASIAMLoginTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_InsertASIAMLoginTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_InsertGHRMLoginTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_InsertGHRMLoginTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_InsertWBEGLoginTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_InsertWBEGLoginTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_ProcessASIAMLoginTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_ProcessASIAMLoginTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_ProcessGHRMLoginTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_ProcessGHRMLoginTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_ProcessWBEGLoginTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_ProcessWBEGLoginTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_InsertASIAMLoginTestData;
        private SqlDatabaseTestActions dbo_InsertGHRMLoginTestData;
        private SqlDatabaseTestActions dbo_InsertWBEGLoginTestData;
        private SqlDatabaseTestActions dbo_ProcessASIAMLoginTestData;
        private SqlDatabaseTestActions dbo_ProcessGHRMLoginTestData;
        private SqlDatabaseTestActions dbo_ProcessWBEGLoginTestData;
    }
}
