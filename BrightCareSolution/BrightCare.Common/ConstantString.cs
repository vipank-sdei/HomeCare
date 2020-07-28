﻿namespace HC.Common
{
    namespace HC.Common
    {
        public class ConstantString
        {

        }
        public static class DatabaseTables
        {
            public const string ClaimServiceLine = "ClaimServiceLine";
            public const string MasterModifiers = "MasterModifiers";
            public const string MasterServiceCode = "MasterServiceCode";
            public const string MasterServiceCodeModifiers = "MasterServiceCodeModifiers";
            public const string PayerServiceCodes = "PayerServiceCodes";
            public const string PayerServiceCodeModifiers = "PayerServiceCodeModifiers";
            public const string PayerAppointmentTypes = "PayerAppointmentTypes";
            public const string Staffs = "Staffs";
            public const string InsuranceCompanies = "InsuranceCompanies";
            public const string PatientGuardian = "PatientGuardian";
            public const string AppointmentType = "AppointmentType";
            public const string EDIGateWay = "EDIGateWay";
            public const string MasterInsuranceTypes = "MasterInsuranceTypes";
            public const string Location = "Location";
            public const string UserRoles = "UserRoles";
            public const string MasterCustomLabels = "MasterCustomLabels";
            public const string MasterTemplates = "MasterTemplates";
            public const string Providers = "Providers";

            public static string DatabaseEntityName(string entityName)
            {
                switch (entityName)
                {
                    case "MasterServiceCode":
                        entityName = "MasterServiceCode";
                        break;
                    case "MasterRoundingRules":
                        entityName = "MasterRoundingRules";
                        break;
                    case "MasterCustomLabels":
                        entityName = "MasterCustomLabels";
                        break;
                    case "MasterICD":
                        entityName = "MasterICD";
                        break;
                    case "MasterImmunization":
                        entityName = "MasterImmunization";
                        break;
                    case "MasterTags":
                        entityName = "MasterTags";
                        break;
                    case "MasterInsuranceTypes":
                        entityName = "MasterInsuranceTypes";
                        break;
                    case "UserRoles":
                        entityName = "UserRoles";
                        break;
                    case "AppointmentType":
                        entityName = "AppointmentType";
                        break;
                    case "Location":
                        entityName = "Location";
                        break;
                    case "SecurityQuestions":
                        entityName = "SecurityQuestions";
                        break;
                    case "EDIGateway":
                        entityName = "EDIGateway";
                        break;
                    case "User":
                        entityName = "User";
                        break;
                    case "InsuranceCompanies":
                        entityName = "InsuranceCompanies";
                        break;
                    case "PayerServiceCodes":
                        entityName = "PayerServiceCodes";
                        break;

                }
                return entityName;
            }
        }
        public static class UserAccountNotification
        {
            public const string EmailNotFound = "Email Id not found";
            public const string AccountDeactiveOrExpirePass = "Your account has been locked out or temporarily deactivated. Please contact your office";
            public const string AccountDeactive = "Your account has been locked out or temporarily deactivated. Please contact your office";
            public const string Success = "Successfully Logged in";
            public const string LoggedOut = "Successfully Logged out";
            public const string UserDeleted = "User Deleted Successfully";
            public const string InvalidPassword = "The password provided is incorrect";
            public const string PasswordExpired = "Your password expired, please update it.";

            public const string LoginFailed = "Something went wrong, please try after some time or contact system administration";
            public const string EmailAlreadyExists = "The email address entered is already in use";
            public const string PrimaryEmailAlreadyExists = "Primary Email and Secondary Email should not be same";
            public const string AccountNoResponseTeam = "Sorry, your account seems not associated with any role";
            public const string LoginFailedStatus = "Failed Login";
            public const string LoginStatus = "Login";
            public const string AccountTrialExpired = "Your trial subscription package has been expired. Please subscribe to other package";
            public const string AccountNotExists = "Sorry we didn't recognize your login details or something went wrong with your account";
            public const string AccountNotAuthorize = "Your account is not authorized to use this service";
            public const string UserNamePasswordNotVaild = "User name or password is not valid";
            public const string FollowInstructionsForChangePassword = "Please check your email and follow the instructions to change password";
            public const string UsernameIncorrect = "The user name provided is incorrect";
            public const string ExpiredLink = "You may have clicked the expire link";
            public const string ProvidedEmailAlreadyExists = "The provided email address already registered. Please use another email";
            public const string ResetPassword = "Reset Password";
            public const string ComplexPasswordMinimumLength = "Password must contain minimum 10 characters, including numeric characters (0–9), uppercase alphabetic characters (A–Z), lowercase alphabetic characters (a–z) and special characters";
            public const string SimplePasswordMinimumLength = "Password must contain minimum 6 characters, including numeric characters (0–9), uppercase alphabetic characters (A–Z), lowercase alphabetic characters (a–z)";
            public const string ClientNotActiveOrDeleted = "It seems that your client currently not active or deleted";
            public const string CheckUserUpdatingError = "Error while updating";
            public const string EmailIDAlreadyExists = "This email id already in use";
            public const string AdminUserCreated = "Admin user created successfully";
            public const string UserCreated = "User created successfully";
            public const string BusinessImpactDescriptor = "Business impact descriptor data saved successfully";
            public const string SystemCategories = "System categories cannot be deleted";
            public const string YourCurrentPassword = "Your current password does not match";
            public const string YourPasswordNotMatchWithConfirmPassword = "Your new password does not match with confirm password";
            public const string YourPasswordChanged = "Your password has been changed successfully";
            public const string IncidentAssessmentQuestions = "Incident assessment questions data saved successfully";
            public const string NameOfYourApplication = "Name of Your Application";
            public const string NoDataFound = "No record(s) found!!";
            public const string ClientProfileUpdated = "Client profile updated successfully";
            public const string ClientProfileAdded = "Client profile added successfully";
            public const string AdminUserUpdated = "Admin user updated successfully";
            public const string UserAlreadyAssigned = "There is a user already assigned for this subset on this role and response team";

            public const string PasswordMatch = "Password should not match with last three password's";

            public const string AccountLockNotification = "Your password will expire in";
            public const string AccountBlockNotification = "Block User";
        }

        public static class StatusMessage
        {
            #region Request
            public const string BadRequest = "Bad Request, Null parameter requested";
            #endregion
            public const string ChatConnectedEstablished = "Chat connection established";
            public const string VerifiedBusinessName = "Domain verified";
            public const string UnVerifiedBusinessName = "This domain not available please contact admin";
            public const string InvalidUserOrPassword = "Invalid username or password.";
            public const string UnknownError = "Sorry, we have encountered an error";
            public const string Success = "Data has been successfully inserted";
            public const string UserCustomFieldSaved = "User's custom fields has been saved successfully";
            public const string AgencySaved = "Agency has been saved successfully.";
            public const string AgencyUpdatedSuccessfully = "Agency has been updated successfully.";
            public const string AgencyAlredyExist = "Agency name already in use";
            public const string SoapSuccess = "Client encounter has been saved successfully.";
            public const string UserCustomFieldUpdated = "User's custom fields has been updated successfully";
            public const string UpdatedSuccessfully = "Data has been updated successfully";
            public const string UserCustomFieldDeleted = "User's custom fields has been deleted successfully";
            public const string Delete = "Data has been deleted successfully";
            public const string InvalidData = "Please enter valid user name";
            public const string VaildData = "Please enter vaild data.";
            public const string ModelState = "Model state is not valid";
            public const string InvalidToken = "Please enter valid token";
            public const string NotFound = "Data not found";
            public const string InvalidCredentials = "Please enter valid credentials.";
            public const string TokenRequired = "Token Required";
            public const string TokenExpired = "Your Token is expired, please re-login";
            public const string ResetPassword = "Reset password's email sent to user";
            public const string ServerError = "Internal Server error";
            public const string FetchMessage = "Success";
            public const string ClaimUpdated = "Claim has been updated successfully";
            public const string ClaimNotExist = "Claim doesn't exist";
            public const string AlreadyExists = "You cannot remove this, as it is associated somewhere in the application";
            public const string ServiceCodeAdded = "Service code has been saved successfully";
            public const string ServiceCodeUpdated = "Service code has been updated successfully";
            public const string ServiceCodeNotExists = "The service code do not exist";
            public const string ModifierNotExists = "The modifier do not exist";
            public const string ServiceCodeDelete = "Service code has been deleted successfully";
            public const string ClaimDelete = "Claim has been deleted successfully";
            public const string ServiceLinePaymentDelete = "Service line payment/adjustment has been deleted successfully";
            public const string ModifierDelete = "Modifier has been deleted successfully";
            public const string ServiceCodeAlreadyExists = "Service code already exist in the claim";
            public const string PatientAlreadyExist = "Client already exist";
            public const string StaffAlreadyExist = "Staff already exist";
            public const string ProviderAlreadyExist = "Provider already exist";
            public const string AdminAlreadyExist = "Admin already exist";
            public const string AppointmentAlreadyExist = "Appointment type already exist";
            public const string EdiAlreadyExist = "This Edi already exist";
            public const string QuestionAlreadyExist = "This question already exist";
            public const string AppointmentTypeAlreadyAssigned = "Appointment type already assigned to payer";
            public const string ClearingHouseAlreadyExist = "Clearing House already exist";
            public const string LocationAlreadyExist = "Location already exist.";

            public const string TagAlreadyExist = "Tag already exist";
            public const string AppConfigurationAlreadyExist = "This configuration already exist";
            public const string AppConfigurationUpdated = "Configurations has been updated successfully";
            public const string InsuranceCompaniesAlreadyExist = "Insurance company already exist";
            public const string CustomLabelAlreadyExist = "Custom field already exist";
            public const string ICDAlreadyExist = "Diagnosis code already exist";
            public const string UserAlreadyExist = "User already exist";
            public const string ModuleAlreadyExist = "Module already exist";
            public const string TemplateAlreadyExist = "Template already exist";
            public const string ClientICDAlreadyLink = "Client already linked with this diagnosis code";
            public const string ClientAllergyAlreadyLink = "Client already linked with this allergy";
            public const string ClientImmunizationAlreadyLink = "Client already linked with this immunization";
            public const string ClientInsuranceAlreadyLink = "Client already linked with this insurance company";
            public const string StaffCustomValue = "Can't insert duplicate values";
            public const string InsuarnceTypeAlreadyExist = "This insurance type already exist";
            public const string RecordAlreadyExists = "[string] already exist";// in table [table]";
            public const string RecordNotExists = "available";
            public const string AddAppointment = "Appointment has been scheduled successfully";
            public const string UpdateAppointment = "Appointment has been updated successfully";

            //Patient portal
            public const string AddPatientAppointment = "Appointment request has been sent successfully";
            public const string UpdatePatientAppointment = "Appointment request has been updated successfully";
            public const string DeletePatientAppointment = "Appointment request has been deleted successfully";

            public const string DeleteAppointment = "Appointment has been deleted successfully";
            public const string CancelAppointment = "Appointment has been cancelled successfully";
            public const string UpdateAppointmentStatus = "Appointment status has been updated successfully";
            public const string UndoCancelAppointment = "Appointment has been restored successfully";
            public const string DeleteAppointmentRecurrence = "Appointment recurring series has been deleted successfully";
            public const string AppointmentNotExists = "Appointment doesn't exist or has been deleted";
            public const string UserRoleAlreadyExist = "Role name already exist";
            public const string UserRoleAlreadyAssignedToUser = "This role is already assigned to user";

            public const string ClientPortalActivated = "Client portal activated successfully";
            public const string ClientPortalDeactivated = "Client portal deactivated successfully";

            public const string ClientActiveStatus = "Your profile is not active, please contact with your system administrator";
            public const string ClientPortalDeactivedAtLogin = "Your portal is not active, please contact with your system administrator";

            public const string ClientActivation = "Client activated successfully";
            public const string ClientDeactivation = "Client deactivated successfully";

            public const string UserActivation = "User activated successfully";
            public const string UserDeactivation = "User deactivated successfully";

            public const string LocationSaved = "Location has been saved successfully.";
            public const string LocationUpdated = "Location has been updated successfully.";
            public const string LocationDeleted = "Location has been deleted successfully.";

            public const string UserBlocked = "[RoleName] has been locked successfully.";
            public const string UserUnblocked = "[RoleName] has been unlocked successfully.";

            public const string PatientProfile = "Client profile has been created/updated successfully.";
            public const string CustomLabelUpdated = "Custom field has been updated successfully.";
            public const string CustomLabelDeleted = "Custom field has been deleted successfully.";

            public const string APISavedSuccessfully = "[controller] has been saved successfully";
            public const string APIUpdatedSuccessfully = "[controller] has been updated successfully";
            public const string DeletedSuccessfully = "[controller] has been deleted successfully";

            public const string ErrorOccured = "Unfortunately, some error was encountered.";
            public const string AuthorizationProcedureSaved = "Authorization procedure has been saved successfully";
            public const string RoundingRuleNotDeleted = "Rounding rule cannot be deleted as it's already assigned to some service codes";
            public const string RoundingRuleDeleted = "Rounding rule has been deleted sucessfully";

            public const string InvalidFile = "Please select a valid CCDA file";

            public const string CCDAImportedSuccessfully = "Client information imported successfully";
            public const string CCDAError = "Error occured while importing Client information";

            public const string EDI837SuccessfullyUploaded = "Claim file has been sent succesfully";
            public const string EDI837UploadError = "Some error occurred while sending claim file";
            public const string EDI837GenerationError = "Some error occurred while generating claim file";
            //public const string EDI837GenerationError = "Some error occurred while creating claim file";
            public const string EDI837ClientDataError = "Some error occurred while sending claim file due to incomplete client(s) data";
            public const string PaymentAdded = "Payment details have been added successfully";
            public const string PaymentUpdated = "Payment details have been updated successfully";
            public const string PaymentDetailNotExists = "Payment details you are trying to update do not exists in our records";

            public const string SavedStaffAvailability = "Staff availability has been saved successfully";
            public const string SavedProviderAvailability = "Provider availability has been saved successfully";
            public const string ResetPasswordLinkNotVaild = "Reset password link is not vaild";

            public const string DocumentNotExist = "Document doesn't exist";
            public const string DocumentDelete = "Document has been deleted successfully";
            public const string InvaildFormat = "You have uploaded an invalid file type.";
            public const string DocumentUploaded = "Documents has been uploaded successfully";

            public const string SelectRole = "Please select one role first";
            public const string SubmitToNonEDIPayer = "Claims has been successfully submitted to non-edi payers";

            //Message
            public const string MessageSent = "Message has been sent succesfully";
            public const string DeleteMessage = "Message has been deleted successfully";
            public const string MessageStatus = "Message Status has been updated successfully";
            public const string MessageFavouriteStatus = "Favourite Status has been updated successfully";
            public const string ModifierAdded = "Modifier has been added successfully";
            public const string ModifierUpdated = "Modifier has been updated successfully";
            public const string ModifierDeleted = "Modifier has been deleted successfully";

            //Master Service Code
            public const string MasterServiceCodeAdded = "Master Service code has been saved successfully";
            public const string MasterServiceCodeUpdated = "Master Service code has been updated successfully";
            public const string ServiceCodeAlreadyExist = "This service code already exist";
            public const string MasterServiceCodeDeleted = "Master Service code has been deleted successfully";

            //Payer Service Code
            public const string PayerServiceCodeAdded = "Payer Service code has been saved successfully";
            public const string PayerServiceCodeUpdated = "Payer Service code has been updated successfully";
            public const string PayerServiceCodeDeleted = "Payer Service code has been deleted successfully";

            //Client
            public const string ClientCreated = "Client has been created successfully";
            public const string ClientUpdated = "Client has been updated successfully";

            // Staff Applied Leave
            public const string StaffLeaveApplied = "Leave has been successfully applied";
            public const string StaffLeaveAppliedUpdated = "Applied Leave has been successfully updated";
            public const string StaffAppliedLeaveDelete = "Applied Leave has been deleted successfully";
            public const string LeaveStatusUpdated = "Leave status has been successfully updated";
            public const string StaffLeaveAppliedDoesNotExist = "Applied Leave does not exist in the current application";

            //Staff
            public const string StaffCreated = "Staff has been created successfully";
            public const string StaffUpdated = "Staff has been updated successfully";
            public const string StaffDelete = "Staff has been deleted successfully";
            public const string StaffCustomLabelSaved = "Staff custom label has been saved successfully";
            public const string StaffCustomLabelUpdated = "Staff custom label has been updated successfully";
            public const string StaffInfoNotFound = "Staff information not found";
            public const string AccountDeactivated = "Your Account is not activated, please ask administration to activate";
            public const string StaffIdRequired = "StaffId not valid, please pass valid value";
            //Client guardian
            public const string ClientGuardianCreated = "Client's Guardian has been created successfully";
            public const string ClientGuardianUpdated = "Client's Guardian has been updated successfully";
            public const string ClientGuardianDelete = "Client's Guardian has been deleted successfully";

            //Client address 
            public const string ClientAddressCreated = "Client's Address has been created successfully";
            public const string ClientAddressUpdated = "Client's Address has been updated successfully";

            //Client Insurance
            public const string ClientInsuranceCreated = "Client's Insurance has been created successfully";
            public const string ClientInsuranceUpdated = "Client's Insurance has been updated successfully";

            //Timesheet
            public const string TimeSheetAdd = "Timesheet info has been added successfully";
            public const string TimeSheetUpdate = "Timesheet info has been updated successfully";
            public const string TimeSheetDelete = "Timesheet info has been deleted successfully";
            public const string TimeSheetSubmitted = "Timesheet has been submitted successfully";

            //Social History
            public const string ClientSocialHistoryCreated = "Client's social history has been created successfully";
            public const string ClientSocialHistoryUpdated = "Client's social history has been Updated successfully";

            //Immunization
            public const string ClientImmunizationCreated = "Client's immunization has been created successfully";
            public const string ClientImmunizationUpdated = "Client's immunization has been updated successfully";
            public const string ClientImmunizationDeleted = "Client's immunization has been deleted successfully";

            //Immunization
            public const string ClientDiagnosisCreated = "Client's diagnosis has been created successfully";
            public const string ClientDiagnosisUpdated = "Client's diagnosis has been updated successfully";
            public const string ClientDiagnosisDeleted = "Client's diagnosis has been deleted successfully";

            //Payroll Group
            public const string PayrollGroupAdded = "Payroll group has been added successfully";
            public const string PayrollGroupUpdated = "Payroll group has been updated successfully";
            public const string PayrollGroupDeleted = "Payroll group has been deleted successfully";
            public const string PayrollGroupDoesNotExist = "Payroll group does not exist in the current application";

            //Agency Holidays
            public const string HolidaysAdded = "Holiday details has been added successfully";
            public const string HolidaysUpdated = "Holiday details has been updated successfully";
            public const string HolidaysDeleted = "Holiday details has been deleted successfully";
            public const string HolidayDoesNotExist = "Holiday does not exist in the current application";


            //Master appointment
            public const string AppointmentTypeCreated = "Appointment type has been created successfully";
            public const string AppointmentTypeUpdated = "Appointment type has been updated successfully";
            public const string AppointmentTypeDeleted = "Appointment type has been deleted successfully";

            //Encounter Signature
            public const string SignatureUpdated = "Client encounter's signed has been updated successfully";
            public const string SignatureCreated = "Client encounter has been signed successfully";

            //Master Tags
            public const string MasterTagCreated = "Master Tag has been created successfully";
            public const string MasterTagUpdated = "Master Tag has been updated successfully";
            public const string MasterTagDeleted = "Master Tag has been deleted successfully";

            //Master ICD
            public const string MasterICDCreated = "Master ICD has been created successfully";
            public const string MasterICDUpdated = "Master ICD has been updated successfully";
            public const string MasterICDDeleted = "Master ICD has been deleted successfully";
            public const string MasterICDDoesNotExist = "Master ICD does not exist in the current application";

            //Payer
            public const string PayerCreated = "Payer has been created successfully";
            public const string PayerUpdated = "Payer has been updated successfully";
            public const string PayerDeleted = "Payer has been deleted successfully";
            public const string PayerDoesNotExist = "Payer does not exists in the current application";


            //Master Security Question
            public const string SecurityQuestionCreated = "Master Security Question has been created successfully";
            public const string SecurityQuestionUpdated = "Master Security Question has been updated successfully";
            public const string SecurityQuestionDeleted = "Master Security Question has been deleted successfully";
            public const string SecurityQuestionDoesNotExist = "Master Security Question not exists in the current application";


            //Payroll Break Time
            public const string BreakTimeAdd = "Payroll break time details has been added/updated successfully";
            public const string BreakTimeUpdate = "Payroll break time details has been added/updated successfully";
            public const string BreakTimeDelete = "Payroll break time details has been deleted successfully";

            //Allergies
            public const string AllergySave = "Client's allergy has been saved successfully.";
            public const string AllergyUpdated = "Client's allergy has been updated successfully.";
            public const string AllergyDeleted = "Client's allergy has been deleted successfully.";

            //Medication
            public const string MedicationSave = "Client's medication has been saved successfully.";
            public const string MedicationUpdated = "Client's medication has been updated successfully.";
            public const string MedicationDeleted = "Client's medication has been deleted successfully.";

            //Vitals
            public const string VitalSave = "Client's vital has been saved successfully.";
            public const string VitalUpdated = "Client's vital has been updated successfully.";
            public const string VitalDeleted = "Client's vital has been deleted successfully.";

            //Authorization
            public const string AuthorizationSave = "Client's authorization has been saved successfully.";
            public const string AuthorizationUpdated = "Client's authorization has been updated successfully.";
            public const string AuthorizationDeleted = "Client's authorization has been deleted successfully.";

            //EDI
            public const string EDISave = "EDI has been saved successfully.";
            public const string EDIUpdated = "EDI has been updated successfully.";
            public const string EDIDeleted = "EDI has been deleted successfully.";

            //Roles
            public const string RoleSave = "Role has been saved successfully.";
            public const string RoleUpdated = "Role has been updated successfully.";
            public const string RoleDeleted = "Role has been deleted successfully.";

            // Payment Status
            public const string PaymentStatusUpdated = "Payment status has been updated successfully";

            //Master Insurance Type
            public const string InsuranceTypeSave = "Insurance type has been saved successfully.";
            public const string InsuranceTypeUpdated = "Insurance type has been updated successfully.";
            public const string InsuranceTypeDeleted = "Insurance type has been deleted successfully.";
            public const string InsuranceTypeDoesNotExist = "Insurance type does not exist in the current application.";


            //payer activity code
            public const string PayerActivitySave = "Payer Activity Code has been saved successfully.";
            public const string PayerActivityUpdated = "Payer Activity Code has been updated successfully.";
            public const string PayerActivityDeleted = "Payer Activity Code has been deleted successfully.";

            public const string EligibilityFileRequestSuccess = "Eligibility request has been sent successfully";
            public const string EligibilityFileRequestFail = "Some error occurred while sending eligibility request";

            //Questionnaire
            public const string CategorySave = "Category has been saved successfully.";
            public const string CategoryUpdated = "Category has been updated successfully.";
            public const string CategoryDeleted = "Category has been deleted successfully.";
            public const string CategoryDoesNotExist = "Category does not exist in the current application.";
            public const string CategoryAlreadyExist = "Category already exist.";

            public const string CategoryCodeSave = "Category Code has been saved successfully.";
            public const string CategoryCodeUpdated = "Category Code has been updated successfully.";
            public const string CategoryCodeDeleted = "Category Code has been deleted successfully.";
            public const string CategoryCodeDoesNotExist = "Category Code does not exist in the current application.";
            public const string CategoryCodeAlreadyExist = "Category code already exist.";

            public const string DocumentSave = "Document has been saved successfully.";
            public const string DocumentUpdated = "Document has been updated successfully.";
            public const string DocumentDeleted = "Document has been deleted successfully.";
            public const string DocumentDoesNotExist = "Document does not exist in the current application.";
            public const string DocumentAlreadyExist = "Document already exist.";

            public const string SectionSave = "Section has been saved successfully.";
            public const string SectionUpdated = "Section has been updated successfully.";
            public const string SectionDeleted = "Section has been deleted successfully.";
            public const string SectionDoesNotExist = "Section does not exist in the current application.";

            public const string SectionItemSave = "Section Item has been saved successfully.";
            public const string SectionItemUpdated = "Section Item has been updated successfully.";
            public const string SectionItemDeleted = "Section Item has been deleted successfully.";
            public const string SectionItemDoesNotExist = "Section Item does not exist in the current application.";

            public const string QuestionnaireAnswerInvalidData = "Patient or Document data not vaild";
            public const string QuestionnaireAssignment = "Questionnaire has been sucessfully assign to client";
            public const string QuestionnaireAssignmentUpdated = "Questionnaire Assignment has been sucessfully updated";
            public const string AlreadyAssigned = "This Questionnaire has been already assigned to this client";

            public const string ClientDocumentSigned = "Client has been signed the document sucessfully";
            public const string ClientSignRequired = "Client signature required";
            public const string StaffDocumentSigned = "Staff has been signed the document sucessfully";

            //Master Templates
            public const string MasterTemplateCreated = "Master Template has been created successfully";
            public const string MasterTemplateUpdated = "Master Template has been updated successfully";
            public const string MasterTemplateDeleted = "Master Template has been deleted successfully";
            public const string MasterTemplateDoesNotExist = "Master Template does not exist in the current application";
            public const string MasterTemplateAlreadyExist = "Master Template already exist";

            //patient Encounter Templates
            public const string PatientEncounterTemplateCreated = "Encounter Template data has been saved successfully";
            public const string PatientEncounterTemplateUpdated = "Encounter Template data has been updated successfully";
            public const string PatientEncounterTemplateDeleted = "Encounter Template data has been deleted successfully";
            public const string PatientEncounterTemplateDoesNotExist = "Encounter Template does not exist in the current application";

            //user invitation
            public const string InvitationSent = "Invitation sent sucessfully";
            public const string InvitationNotSent = "Invitation not sent";
            public const string UserAddedButInvitationNotSent = "User info added but invitation email not sent";
            public const string InvitationExisted = "Invitation sent already";
            public const string InvitationNotDeleted = "Invitation not deleted, please try again";
            public const string InvitationDeleted = "Invitation deleted successfully";
            public const string RequestNotCompleted = "Request not completed due to bad parameter initialization";
            public const string InvitaionTokenValid = "Invitation token is valid";
            public const string InvitaionTokenNotValid = "Invitation token is not valid";
            public const string InvitaionTokenAlreadyUsed = "User as of now registered with same token number, it would be ideal if you contact organization for additional help.";

            //User Registration
            public const string UserRegistredSuccessfully = "Registration information saved successfully, please wait until account activated";
            public const string UserRegistredNotSaved = "Registration information not saved";

            //Username
            public const string UsernameAvailable = "User name you have entered is accessible to utilize.";
            public const string UsernameTaken = "Username effectively taken, if it's not too much trouble pick distinctive one";
            //Email Log
            public const string EmailLogNotFound = "Email Log Not Found, Bad Request";
            public const string EmailLogSavedSuccessfully = "Email Log saved successfully";
            public const string EmailLogNotSaved = "Email Log not saved";

            //Reject Invitation Log
            public const string AlreadyRejectedInvitation = "This Invitation has been as of now rejected";
            public const string InvitationNotRejected = "Invitation not rejected";
            public const string InvitationRejectedSuccessfully = "Invitation has been rejected successfully";

            //Notification Settings
            public const string AddNotification = "Notification has been save successfully";
            public const string NoContent = "No Content";

            #region Staff Profile
            //Experience
            public const string ExperienceSaved = "{0} experience saved successfully out of {1}";
            public const string ExperienceNotSaved = "Experience not saved, please try again";

            //Qualification
            public const string QualificationSaved = "{0} qualification saved successfully out of {1}";
            public const string QualificationNotSaved = "Qualification not saved, please try again";

            //Award
            public const string AwardSaved = "{0} award saved successfully out of {1}";
            public const string AwardNotSaved = "Award not saved, please try again";

            //Master Services
            public const string ServiceIdRequired = "Service id required";
            public const string OrganizationIdRequired = "Oraganization id required";
            public const string MasterServicesSaved = "Master services saved successfully";
            public const string MasterServicesNotSaved = "Master services not saved";
            public const string ServiceNameAvailable = "Service name you have entered is accessible to utilize.";
            public const string ServiceNameTaken = "Service name effectively exists, if it's not too much trouble pick distinctive one";

            public const string MasterServicesDeleted = "Master services deleted successfully";
            public const string MasterServicesNotDeleted = "Master services not deleted";
            #endregion Staff Profile

            public const string AppointmentPaymentTokenExisted = "Payment Token Already Existed";
            public const string AppointmentPaymentSaved = "Appointment payment done successfully";
            public const string AppointmentPaymentNotSaved = "Appointment payment not done";

            #region Appointment Payment 
            public const string AppointmentPaymentNotFound = "Appointment payments not found";
            public const string AppointmentPaymentFound = "Appointment payments found";
            public const string UserNotFound = "Logged IN User Data not found";
            #endregion Appointment Payment 

            #region Group Session
            public const string OTKeyNotFound = "Open Tok api key not found";
            public const string UserInvitedAlready = "{0} invited already for group session";
            public const string InviationAddedButEmailNotSent = "Invitaion added but invitation email not sent";
            #endregion Group Session

            //Provider
            public const string ProviderCreated = "Provider has been created successfully";
            public const string ProviderUpdated = "Provider has been updated successfully";
            public const string ProviderDelete = "Provider has been deleted successfully";
            public const string ProviderCustomLabelSaved = "Provider custom label has been saved successfully";
            public const string ProviderCustomLabelUpdated = "Provider custom label has been updated successfully";
            public const string ProviderInfoNotFound = "Provider information not found";
            public const string ProviderIdRequired = "ProviderId not valid, please pass valid value";

            public const string AdminDelete = "Deleted successfully";
        }



        public static class PaymentStatusMessages
        {
            public const string PaymentSuccess = "Your transaction has been completed successfully";
            public const string PaymentFail = "We are sorry your transaction has not been completed";
            public const string PaymentDeclined = "Unfortunately your transaction has been declined by the bank";
            public const string PaymentRejected = "Unfortunately your transaction has been rejected by the bank";
            public const string PaymentUnknownError = "Unfortunately some unknown errors has occurred";
            public const string ReferenceGenerationError = "Unfortunately some errors has occurred while generating customer number";
            public const string PaymentRefund = "Unfortunately some errors has occurred while registering your account, your amount will be refunded in next 5-7 business days on same payment type. {0}";
            public const string PaymentRefundUpgradeDowngrade = "Unfortunately some errors has occurred while updating your account, your amount will be refunded in next 5-7 business days on same payment type. {0}";
            public const string NoPaymentRefund = "Unfortunately some errors has occurred while registering your account";
            public const string DuplicateTransaction = "Possible duplicate payment attempt. Please check your statement and confirm whether transaction has been processed before retrying";
            public const string PaymentConfirmationMessage = "The process has been completed successfully. A confirmation email has been sent to you";
        }

        public static class EntityStatusNotification
        {
            public const string EntityCreated = "Entity created succesfully";
            public const string EntityUpdated = "Entity has been updated successfully";
            public const string EntityDeleted = "Entity deleted successfully";

        }

        public static class OfficesStatusNotification
        {
            public const string OfficeCreated = "Office created succesfully";
            public const string OfficeUpdated = "Office has been updated successfully";
            public const string OfficeDeleted = "Office deleted successfully";

        }

        public static class ImagesPath
        {

            public const string PatientInsurancePhotos = "//Images//PatientInsurancePhotos//pic_";
            public const string PatientInsuranceThumbPhotos = "//Images//PatientInsurancePhotos//thumb//pic_thumb_";

            public const string PatientPhotos = "//Images//PatientPhotos//";
            public const string PatientThumbPhotos = "//Images//PatientPhotos//thumb//";

            public const string StaffPhotos = "//Images//StaffPhotos//";
            public const string StaffThumbPhotos = "//Images//StaffPhotos//thumb//";

            public const string ProviderPhotos = "//Images//ProviderPhotos//";
            public const string ProviderThumbPhotos = "//Images//ProviderPhotos//thumb//";

            public const string PatientInsuranceFront = "//Images//PatientInsuranceFront//";
            public const string PatientInsuranceFrontThumb = "//Images//PatientInsuranceFront//thumb//";
            public const string PatientInsuranceBack = "//Images//PatientInsuranceBack//";
            public const string PatientInsuranceBackThumb = "//Images//PatientInsuranceBack//thumb//";

            public const string OrganizationImages = "//Images//Organization//"; //its used for both logo and favicon of the organization

            public const string EncounterSignImages = "//Images//Encounter//";

            public const string UploadClientDocuments = "//Documents//ClientDocuments//";
            public const string UploadStaffDocuments = "//Documents//StaffDocuments//";


            public const string MessageDocuments = "//Message//Documents//";
        }

        public static class AuditLogsScreen
        {
            public const string PatientEncounter = "Patient Encounter";
            public const string Login = "Login";
            public const string Billing = "Billing";
            public const string MasterModifier = "Master Modifier";
            public const string AddServiceLine = "Add Service Line";
            public const string UpdateServiceLine = "Update Service Line";
            public const string DeleteServiceLine = "Delete Service Line";
            public const string DeleteServiceLinePayment = "Delete Service Line Payment/Adjustment";
            public const string UpdateClaim = "Update Claim";
            public const string DeleteClaim = "Delete Claim";
            public const string CreateStaff = "Create Staff";
            public const string UpdateStaff = "Update Staff";
            public const string DeleteStaff = "Delete Staff";
            public const string UpdatePayerInfo = "Update Payer Information";
            public const string CreatePayerInfo = "Create Payer Information";
            public const string DeletePayerInfo = "Delete Payer Information";

            public const string UpdatePayerServiceCodes = "Update Payer ServiceCodes";
            public const string CreatePayerServiceCodes = "Create Payer ServiceCodes";
            public const string DeletePayerServiceCodes = "Delete Payer ServiceCodes";

            public const string UpdatePayerActivity = "Update Payer Activity";
            public const string CreatePayerActivity = "Create Payer Activity";
            public const string DeletePayerActivity = "Delete Payer Activity";

            public const string UpdateAppointmentType = "Update Appointment Type";
            public const string CreateAppointmentType = "Create Appointment Type";
            public const string DeleteAppointmentType = "Delete Appointment Type";

            public const string CreateRoundingRule = "Create Rounding Rule";
            public const string UpdateRoundingRule = "Update Rounding Rule";
            public const string DeleteRoundingRule = "Delete Rounding Rule";

            public const string CreateRoundingRuleDetails = "Create Rounding Rule Details";
            public const string UpdateRoundingRuleDetails = "Update Rounding Rule Details";
            public const string DeleteRoundingRuleDetails = "Delete Rounding Rule Details";
        }
        public static class AuditLogAction
        {
            public const string Create = "Create";
            public const string Modify = "Modify";
            public const string Delete = "Delete";
            public const string Access = "Access";
            public const string Login = "Login";
            public const string Logout = "Logout";
        }

        public static class LoginLogLoginAttempt
        {
            public const string Failed = "Failed";
            public const string Success = "Success";
        }
        public static class SecurityQuestionNotification
        {
            public const string RequiredAnswers = "Please give answers of these questions.";
            public const string AtleastOneAnswer = "Please answer any one from these questions.";
            public const string IncorrectAnswer = "Answer doesn't match please retry.";
        }

        public static class HCOrganizationConnectionStringEnum
        {
            public const string Server = "75.126.168.31,7008";
            public const string Database = "BrightCareLocal";
            public const string User = "brightcare";
            public const string Password = "brightcare";
            public const string Host = "brightcare"; //local
            //public const string Host = "75.126.168.31,7008"; //staging
            public const string DomainUrl = "brightcare";
        }
        public static class HCMasterConnectionStringEnum
        {
            public const string Server = "75.126.168.31,7008"; 
            public const string Database = "BrightCareMasterLocal";
            public const string User = "brightcare";
            public const string Password = "brightcare";
            public const string Host = "brightcare"; //local
            //public const string Host = "75.126.168.31,7008"; //staging
        }

        public static class OpenTokAPIDetails
        {
            public const int APIKey = 46625922;
            public const string APISecret = "a7203deec1775cc9a42576bac2eafee24fde1f35";
            public const string APIUrl = "https://api.opentok.com";
        }

        public static class AppointmentStatus
        {
            public const string APPROVED = "APPROVED";
            public const string PENDING = "PENDING";
            public const string DECLINED = "DECLINED";
            //public const string CANCEL = "CANCEL";
            public const string CANCELLED = "CANCELLED";

            public const string TENTATIVE = "TENTATIVE";
            public const string ACCEPTED = "ACCEPTED";
            public const string REJECTED = "REJECTED";
            public const string AUTO_CONFIRM = "AUTO_CONFIRM";
        }
        public static class DocumentStatus
        {
            public const string InProgress = "In Progress";
            public const string Completed = "Completed";
            public const string ToDo = "To Do";

        }
        public static class GlobalCodeName
        {
            public const string AppointmentStatus = "appointmentstatus";
            public const string DocumentStatus = "documentstatus";
        }
    }
}
