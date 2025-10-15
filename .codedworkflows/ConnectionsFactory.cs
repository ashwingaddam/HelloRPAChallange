using UiPath.CodedWorkflows;
using System;

namespace HelloRPAChallage_Windows
{
    public class ExcelFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Shared_ezra_dantowitz_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Shared_grant_gernes_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Shared_james_reames_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection HackathonScoping_Aloha_ezra_dantowitz_uipath_com__4 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Shared_neeharika_thirukkovalluri_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Autopilot_dina_own_uipath_com__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Autopilot_dina_own_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Autopilot_dina_own_uipath_com__4 { get; set; }

        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
            Shared_ezra_dantowitz_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("bc9da4f6-7b58-4a89-88d3-fe2828d36ea9", resolver);
            Shared_grant_gernes_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("59a13139-2c4b-426a-b580-c82c3c469557", resolver);
            Shared_james_reames_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("589e3879-c35a-4fc4-818c-623ca87d4cd8", resolver);
            HackathonScoping_Aloha_ezra_dantowitz_uipath_com__4 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("0b1e98c9-c097-4300-80f1-9f1e8fa6a6b5", resolver);
            Shared_neeharika_thirukkovalluri_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("8a14c818-6af4-4d8c-a8e0-6faef526bbef", resolver);
            Autopilot_dina_own_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("5c077328-3d5b-4cbe-85a3-62a408703d3f", resolver);
            Autopilot_dina_own_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("9d7689c2-1cc5-4927-a350-13199922b8df", resolver);
            Autopilot_dina_own_uipath_com__4 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("823a5235-f249-4f41-89a5-0a1cd18153ea", resolver);
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Shared_Panic_at_the_Debugger_andrew_cook_uipath_com__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection HackathonScoping_Aloha_ezra_dantowitz_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection HackathonScoping_License_Compliance_and_Optimization_Agent_stephen_madigan_uipath_com__3 { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            Shared_Panic_at_the_Debugger_andrew_cook_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("8b42e418-f23c-4556-b980-0a4e47a95c01", resolver);
            HackathonScoping_Aloha_ezra_dantowitz_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("38c1eac9-2ee7-4422-b8dd-79fef6ab1f3a", resolver);
            HackathonScoping_License_Compliance_and_Optimization_Agent_stephen_madigan_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("f3133416-9536-45b9-8316-43968052d6a3", resolver);
        }
    }

    public class OneDriveFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Shared_ezra_dantowitz_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Shared_grant_gernes_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Shared_james_reames_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection HackathonScoping_Aloha_ezra_dantowitz_uipath_com__4 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Shared_neeharika_thirukkovalluri_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Autopilot_dina_own_uipath_com__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Autopilot_dina_own_uipath_com__3 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Autopilot_dina_own_uipath_com__4 { get; set; }

        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            Shared_ezra_dantowitz_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("bc9da4f6-7b58-4a89-88d3-fe2828d36ea9", resolver);
            Shared_grant_gernes_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("59a13139-2c4b-426a-b580-c82c3c469557", resolver);
            Shared_james_reames_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("589e3879-c35a-4fc4-818c-623ca87d4cd8", resolver);
            HackathonScoping_Aloha_ezra_dantowitz_uipath_com__4 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("0b1e98c9-c097-4300-80f1-9f1e8fa6a6b5", resolver);
            Shared_neeharika_thirukkovalluri_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("8a14c818-6af4-4d8c-a8e0-6faef526bbef", resolver);
            Autopilot_dina_own_uipath_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("5c077328-3d5b-4cbe-85a3-62a408703d3f", resolver);
            Autopilot_dina_own_uipath_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("9d7689c2-1cc5-4927-a350-13199922b8df", resolver);
            Autopilot_dina_own_uipath_com__4 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("823a5235-f249-4f41-89a5-0a1cd18153ea", resolver);
        }
    }
}