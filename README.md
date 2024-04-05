# Demo_Multiple_APIS
Multiple APIS Demo

INSTALLING THE CODE
The following are detailed instructions for installing the code.

Ensure you have Visual Studio 2022 Installed.

Download or clone the code from this repository.

If you download as a zip file, be sure to unzip it.

Navigate to the Multiple_APIS_Demo folder.

Open the Multiple_APIS_Demo solution from the folder.

The solution will be open in Visual Studio.

Build API2 Project and deploy that API in http://localhost:424 (or any port and need to modify code based on that).

Build API3 Project and deploy that API in http://localhost:425 (or any port and need to modify code based on that).

Build API1 Project and deploy that API in http://localhost:423 (or any port and need to modify code based on that).

There are some setups required in Azure portal for App Registration. Add a user to that app. Get the following setting and update in the 
appsettings.json file
"AzureAd": {
    "Instance": "https://login.microsoftonline.com/",
    "TenantId": "e913dbf5-f3af-4adf-86db-ebe824cc7203",
    "ClientId": "2d9adc55-488c-4267-8482-0a8e421111b5",
    "Scopes": "ApiRead",
    "CallbackPath": "/signin-oidc"
  },
The code implemented Azure Authentication, so when you run the API1 it will give you the 401 error.


The application should then compile and launch in your default browser.


