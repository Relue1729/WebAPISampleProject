# WebAPISampleProject
Web API technical test assignment

Assignment Description:

There is a RGDialogsClients entity. It contains the information about which users have interacted within a specific dialogue.
We can have an indeterminate abount of IDClients that exist within one dialogue.
Init function allows us to get a list of entities, which we could later process.

Requirements Specification:

Create WebAPI project which would have an API method that would look for dialogues with the client IDs that were passed to the method.
Method should accept a list of client IDs for which we need to find a dialogue. We need to find a dialogue that has all passed Client IDs. If such dialogue is not present we should return an empty GUID.
If the dialogue has been found we should return its ID.
Method should conform to OpenAPI specification and accessible through SwaggerUI

![Alt text](/screenshot.png?raw=true "Screenshot")
