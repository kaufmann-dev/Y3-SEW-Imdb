# Imdb
 
Make sure to rename `appsettings.json.example` in the folder `View` to `appsettings.json` and update the credentials accordingly. For security purposes, this file is not included in the Git repository.

```json
{
 "Logging": {
   "LogLevel": {
     "Default": "Information",
     "Microsoft": "Warning",
     "Microsoft.Hosting.Lifetime": "Information"
   }
 },
 "AllowedHosts": "*",
 "ConnectionStrings": {
   "DefaultConnection": "server=<server_address>; port=<exposed_port>; database=<database>; user=<user>; password=<password>; Persist Security Info=False; Connect Timeout=300"
 }
}
```
