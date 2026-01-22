using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using CPHAllocationDayOne;

[assembly: WorkflowRunnerServiceAttribute(typeof(CPHAllocationDayOne.WorkflowRunnerService))]
namespace CPHAllocationDayOne
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Assign Case.xaml
        /// </summary>
        public void Assign_Case(string in_strURL, string in_strCaseTitle)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Assign Case.xaml", new Dictionary<string, object>{{"in_strURL", in_strURL}, {"in_strCaseTitle", in_strCaseTitle}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Assign Case.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Assign_Case(string in_strURL, string in_strCaseTitle, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Assign Case.xaml", new Dictionary<string, object>{{"in_strURL", in_strURL}, {"in_strCaseTitle", in_strCaseTitle}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Format Address.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, string> Format_Address(string in_strKeyName, System.Collections.Generic.Dictionary<string, string> io_dictFormDetails)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Format Address.xaml", new Dictionary<string, object>{{"in_strKeyName", in_strKeyName}, {"io_dictFormDetails", io_dictFormDetails}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, string>)result["io_dictFormDetails"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Format Address.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, string> Format_Address(string in_strKeyName, System.Collections.Generic.Dictionary<string, string> io_dictFormDetails, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Format Address.xaml", new Dictionary<string, object>{{"in_strKeyName", in_strKeyName}, {"io_dictFormDetails", io_dictFormDetails}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, string>)result["io_dictFormDetails"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Enter New Customer Record.xaml
        /// </summary>
        public void Enter_New_Customer_Record(string in_strCRN)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Enter New Customer Record.xaml", new Dictionary<string, object>{{"in_strCRN", in_strCRN}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Enter New Customer Record.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Enter_New_Customer_Record(string in_strCRN, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Enter New Customer Record.xaml", new Dictionary<string, object>{{"in_strCRN", in_strCRN}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/NetworkConnectivityTool.xaml
        /// </summary>
        public void NetworkConnectivityTool()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\NetworkConnectivityTool.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/NetworkConnectivityTool.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void NetworkConnectivityTool(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\NetworkConnectivityTool.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Add Second Contact to Business.xaml
        /// </summary>
        public void Add_Second_Contact_to_Business(string in_strCRN)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Add Second Contact to Business.xaml", new Dictionary<string, object>{{"in_strCRN", in_strCRN}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Add Second Contact to Business.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Add_Second_Contact_to_Business(string in_strCRN, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Add Second Contact to Business.xaml", new Dictionary<string, object>{{"in_strCRN", in_strCRN}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/tc01 Get Transaction Data.xaml
        /// </summary>
        public void tc01_Get_Transaction_Data()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\tc01 Get Transaction Data.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/tc01 Get Transaction Data.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Get_Transaction_Data(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\tc01 Get Transaction Data.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check and Update Priority.xaml
        /// </summary>
        public void Check_and_Update_Priority(System.DateTime in_dateArrival)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check and Update Priority.xaml", new Dictionary<string, object>{{"in_dateArrival", in_dateArrival}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check and Update Priority.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Check_and_Update_Priority(System.DateTime in_dateArrival, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check and Update Priority.xaml", new Dictionary<string, object>{{"in_dateArrival", in_dateArrival}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Get Form Details.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, string> Get_Form_Details(System.Data.DataTable in_dtBusinessAndLegal)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Get Form Details.xaml", new Dictionary<string, object>{{"in_dtBusinessAndLegal", in_dtBusinessAndLegal}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, string>)result["out_dictFormDetails"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Get Form Details.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, string> Get_Form_Details(System.Data.DataTable in_dtBusinessAndLegal, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Get Form Details.xaml", new Dictionary<string, object>{{"in_dtBusinessAndLegal", in_dtBusinessAndLegal}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, string>)result["out_dictFormDetails"];
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(bool in_boolUnattended)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_boolUnattended", in_boolUnattended}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(bool in_boolUnattended, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_boolUnattended", in_boolUnattended}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Add Internal Note.xaml
        /// </summary>
        public void Add_Internal_Note(string in_strSubject, string in_strDescription)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Add Internal Note.xaml", new Dictionary<string, object>{{"in_strSubject", in_strSubject}, {"in_strDescription", in_strDescription}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Add Internal Note.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Add_Internal_Note(string in_strSubject, string in_strDescription, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Add Internal Note.xaml", new Dictionary<string, object>{{"in_strSubject", in_strSubject}, {"in_strDescription", in_strDescription}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber, System.Data.DataTable io_dtCaseUpdates) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, System.DateTime in_dateCaseStartTime, string in_strWorkLogFilepath, System.Exception in_SystemException, int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber, System.Data.DataTable io_dtCaseUpdates)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_dateCaseStartTime", in_dateCaseStartTime}, {"in_strWorkLogFilepath", in_strWorkLogFilepath}, {"in_SystemException", in_SystemException}, {"io_intConSysEx", io_intConSysEx}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_dtCaseUpdates", io_dtCaseUpdates}}, default, default, default, GetAssemblyName());
            return ((int)result["io_intConSysEx"], (int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (System.Data.DataTable)result["io_dtCaseUpdates"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber, System.Data.DataTable io_dtCaseUpdates) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, System.DateTime in_dateCaseStartTime, string in_strWorkLogFilepath, System.Exception in_SystemException, int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber, System.Data.DataTable io_dtCaseUpdates, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_dateCaseStartTime", in_dateCaseStartTime}, {"in_strWorkLogFilepath", in_strWorkLogFilepath}, {"in_SystemException", in_SystemException}, {"io_intConSysEx", io_intConSysEx}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_dtCaseUpdates", io_dtCaseUpdates}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_intConSysEx"], (int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (System.Data.DataTable)result["io_dtCaseUpdates"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> InitAllSettings(string in_OrchestratorFolders, bool in_RetrieveCredentials)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_OrchestratorFolders", in_OrchestratorFolders}, {"in_RetrieveCredentials", in_RetrieveCredentials}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential>)result["out_Credentials"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> InitAllSettings(string in_OrchestratorFolders, bool in_RetrieveCredentials, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_OrchestratorFolders", in_OrchestratorFolders}, {"in_RetrieveCredentials", in_RetrieveCredentials}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential>)result["out_Credentials"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Validate Title.xaml
        /// </summary>
        public string Validate_Title(string in_strFirstName, string in_strMiddleNames, string in_strLastName, string io_strTitle)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Validate Title.xaml", new Dictionary<string, object>{{"in_strFirstName", in_strFirstName}, {"in_strMiddleNames", in_strMiddleNames}, {"in_strLastName", in_strLastName}, {"io_strTitle", io_strTitle}}, default, default, default, GetAssemblyName());
            return (string)result["io_strTitle"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Validate Title.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Validate_Title(string in_strFirstName, string in_strMiddleNames, string in_strLastName, string io_strTitle, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Validate Title.xaml", new Dictionary<string, object>{{"in_strFirstName", in_strFirstName}, {"in_strMiddleNames", in_strMiddleNames}, {"in_strLastName", in_strLastName}, {"io_strTitle", io_strTitle}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_strTitle"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create New Business Record.xaml
        /// </summary>
        public string Create_New_Business_Record(System.Collections.Generic.Dictionary<string, string> in_dictFormDetails)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create New Business Record.xaml", new Dictionary<string, object>{{"in_dictFormDetails", in_dictFormDetails}}, default, default, default, GetAssemblyName());
            return (string)result["out_strSBI"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create New Business Record.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Create_New_Business_Record(System.Collections.Generic.Dictionary<string, string> in_dictFormDetails, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create New Business Record.xaml", new Dictionary<string, object>{{"in_dictFormDetails", in_dictFormDetails}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_strSBI"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Update Case Title.xaml
        /// </summary>
        public void Update_Case_Title(string in_strCaseTitle, bool in_boolException)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Update Case Title.xaml", new Dictionary<string, object>{{"in_strCaseTitle", in_strCaseTitle}, {"in_boolException", in_boolException}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Update Case Title.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Update_Case_Title(string in_strCaseTitle, bool in_boolException, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Update Case Title.xaml", new Dictionary<string, object>{{"in_strCaseTitle", in_strCaseTitle}, {"in_boolException", in_boolException}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Transaction.xaml
        /// </summary>
        public System.Data.DataTable Process_Transaction(System.Data.DataTable in_dtBusinessAndLegal, System.Data.DataTable io_dtCaseUpdates)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Transaction.xaml", new Dictionary<string, object>{{"in_dtBusinessAndLegal", in_dtBusinessAndLegal}, {"io_dtCaseUpdates", io_dtCaseUpdates}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCaseUpdates"];
        }

        /// <summary>
        /// Invokes the Process/Process Transaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Process_Transaction(System.Data.DataTable in_dtBusinessAndLegal, System.Data.DataTable io_dtCaseUpdates, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Transaction.xaml", new Dictionary<string, object>{{"in_dtBusinessAndLegal", in_dtBusinessAndLegal}, {"io_dtCaseUpdates", io_dtCaseUpdates}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCaseUpdates"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Update Case Title Exception.xaml
        /// </summary>
        public void Update_Case_Title_Exception(string in_strCaseTitle, string in_strExceptionMessage)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Update Case Title Exception.xaml", new Dictionary<string, object>{{"in_strCaseTitle", in_strCaseTitle}, {"in_strExceptionMessage", in_strExceptionMessage}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Update Case Title Exception.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Update_Case_Title_Exception(string in_strCaseTitle, string in_strExceptionMessage, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Update Case Title Exception.xaml", new Dictionary<string, object>{{"in_strCaseTitle", in_strCaseTitle}, {"in_strExceptionMessage", in_strExceptionMessage}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (bool out_boolLastTransaction, System.Data.DataTable io_dtCases) GetTransactionData(int in_TransactionNumber, string in_strProcessType, bool in_boolContinue, System.Data.DataTable io_dtCases)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_strProcessType", in_strProcessType}, {"in_boolContinue", in_boolContinue}, {"io_dtCases", io_dtCases}}, default, default, default, GetAssemblyName());
            return ((bool)result["out_boolLastTransaction"], (System.Data.DataTable)result["io_dtCases"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (bool out_boolLastTransaction, System.Data.DataTable io_dtCases) GetTransactionData(int in_TransactionNumber, string in_strProcessType, bool in_boolContinue, System.Data.DataTable io_dtCases, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_strProcessType", in_strProcessType}, {"in_boolContinue", in_boolContinue}, {"io_dtCases", io_dtCases}}, default, isolated, default, GetAssemblyName());
            return ((bool)result["out_boolLastTransaction"], (System.Data.DataTable)result["io_dtCases"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/UNUSED - Get Cases.xaml
        /// </summary>
        public System.Data.DataTable UNUSED___Get_Cases()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\UNUSED - Get Cases.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dtCases"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/UNUSED - Get Cases.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable UNUSED___Get_Cases(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\UNUSED - Get Cases.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dtCases"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create New Customer.xaml
        /// </summary>
        public string Create_New_Customer(System.Collections.Generic.Dictionary<string, string> in_dictFormDetails)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create New Customer.xaml", new Dictionary<string, object>{{"in_dictFormDetails", in_dictFormDetails}}, default, default, default, GetAssemblyName());
            return (string)result["out_strCRN"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Create New Customer.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Create_New_Customer(System.Collections.Generic.Dictionary<string, string> in_dictFormDetails, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Create New Customer.xaml", new Dictionary<string, object>{{"in_dictFormDetails", in_dictFormDetails}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_strCRN"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Validate Title.xaml
        /// </summary>
        public void tc01_Validate_Title()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Validate Title.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Validate Title.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Validate_Title(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Validate Title.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Search Rural Payments.xaml
        /// </summary>
        public void Search_Rural_Payments(System.Collections.Generic.Dictionary<string, string> in_dictSearchFields, string in_strMobile, string in_strLandline, string in_strEmail)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Search Rural Payments.xaml", new Dictionary<string, object>{{"in_dictSearchFields", in_dictSearchFields}, {"in_strMobile", in_strMobile}, {"in_strLandline", in_strLandline}, {"in_strEmail", in_strEmail}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Search Rural Payments.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Search_Rural_Payments(System.Collections.Generic.Dictionary<string, string> in_dictSearchFields, string in_strMobile, string in_strLandline, string in_strEmail, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Search Rural Payments.xaml", new Dictionary<string, object>{{"in_dictSearchFields", in_dictSearchFields}, {"in_strMobile", in_strMobile}, {"in_strLandline", in_strLandline}, {"in_strEmail", in_strEmail}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Search Rural Payments.xaml
        /// </summary>
        public void tc01_Search_Rural_Payments()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Search Rural Payments.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Search Rural Payments.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Search_Rural_Payments(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Search Rural Payments.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GlobalExceptionHandler.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalExceptionHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalExceptionHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the GlobalExceptionHandler.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Activities.Contracts.ErrorAction GlobalExceptionHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalExceptionHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Format Address.xaml
        /// </summary>
        public void tc01_Format_Address()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Format Address.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Format Address.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Format_Address(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Format Address.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create New Business Record.xaml
        /// </summary>
        public void tc01_Create_New_Business_Record()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create New Business Record.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create New Business Record.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Create_New_Business_Record(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create New Business Record.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Get Form Details.xaml
        /// </summary>
        public void tc01_Get_Form_Details()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Get Form Details.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Get Form Details.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Get_Form_Details(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Get Form Details.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create New Customer.xaml
        /// </summary>
        public void tc01_Create_New_Customer()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create New Customer.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/tc01 Create New Customer.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void tc01_Create_New_Customer(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\tc01 Create New Customer.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}