### CORS - Cross Origin Resource Sharing

We use CORS to allow your browser to access different servers (your BIG-IPs) and display the content in our browser based application, the honeyb.io iRule editor. We can also use this same technique to have your browser utilize the BIG-IP's iControl REST API, to modify data on those same BIG-IPs. As it is not something normally used in daily operations, its *disabled in the BIG-IP by default*. We've come up with two different methods to help you safely share your BIG-IP with your browser. First though a warning, access to the BIG-IP management HTTPS site should always be restricted as much as possible. For instance, putting the access on a restricted network or available through specific IPs such as an admin VPN IP range, and never allowing access on an untrusted network such as the internet.

CORS is a method to allow your browser to connect to another domain or server to display data in the page you are currently using. Its a method that can be abused, which is why its something you need to specifically enable. For example, a site could attempt to post data from your current page to your bank and gather data, or perhaps a trojan could inject scripts into your banking site, and send that data somewhere else (although you have bigger problems at this point).

#### Option 1 - Modify your apache configuration
The simplest way to allow CORS requests to your BIG-IP is to configure the native apache httpd server to set the proper headers for your browser to determine it is a safe request to make. Remember, once you have loaded the honeyb.io iRule editor, it is all run locally, and no data is sent to our servers. For security reasons, and because the request is authenticated, and sends that data via CORS, the browser requires two different requests. The first is called a pre-flight check, which sends an **OPTIONS** request to the BIG-IP as a preliminary check that what it is trying is safe, and the second is the actual GET, POST, PUT or DELETE request to the REST API of the BIG-IP. The BIG-IP is configured to block the OPTIONS request, but you can force it to respond by configuring a 200 response on any OPTIONS request to the Apache server. The second security check is whether the server allows CORS and the different request types. The following snippet added to an apache server tells it to allow all of this. We suggest using the `tmsh sys httpd ssl-include` command to add this so it survives reboots, and upgrades. Also, you can modify to include things such as specific source addresses as needed to increase security. Also, if you're using CORS for sites other than the honeyb.io iRule editor, you can change the origin to * from https://honeyb.io.

##### Add to bigip_base.conf

```
sys httpd {
    ssl-include "
  Header always set Access-Control-Allow-Origin \"https://honeyb.io\"
  Header always add Access-Control-Allow-Headers \"origin, x-requested-with, content-type, Authorization\"
  Header always add Access-Control-Allow-Methods \"PUT, GET, POST, DELETE, OPTIONS\"
  RewriteEngine On
  RewriteCond %{REQUEST_METHOD} OPTIONS
  RewriteRule ^(.*)$ $1 [R=200,L]
"
}
```                 

##### Use TMSH to interactively edit

Edit the httpd properties with the following command (from the `tmsh` shell)
```
edit sys httpd all-properties
```

Paste the code into the ssl-include section of the httpd properties

```

Header always set Access-Control-Allow-Origin "https://honeyb.io"
Header always add Access-Control-Allow-Headers "origin, x-requested-with, content-type, Authorization"
Header always add Access-Control-Allow-Methods "PUT, GET, POST, DELETE, OPTIONS"
RewriteEngine On
RewriteCond %{REQUEST_METHOD} OPTIONS
RewriteRule ^(.*)$ $1 [R=200,L]
```


#### Option 2 - Use a Virtual Server
As the BIG-IP is a powerful proxy, you can add headers and return responses by utilizing an iRule applied on top of your management connection. This is a little bit tricky as you need to have a virtual server that targets the devices management or self-ip as its pool member, and we've found depending on version we're able to get this working or not. You can't use the loopback address as the pool member, so you'll need to either use a second BIG-IP, or route the traffic out a self-ip, and back in the management network's routing.

Once you have the connection working, you'll need to set the appropriate CORS headers and responses. The iRule below will add the headers, it will require a standard virtual with a client-ssl profile and an http profile to parse the traffic.

```
when CLIENT_ACCEPTED {
  set rest_flag 0
}

when HTTP_REQUEST {
  if {[HTTP::uri] starts_with "/mgmt/tm"} {
    set rest_flag 1
    if {[[HTTP::method] to_lower] eq "options"} {
      HTTP::respond 200 {
        Access-Control-Allow-Origin: "https://honeyb.io"
        Access-Control-Allow-Headers "origin, x-requested-with, content-type, Authorization"
        Access-Control-Allow-Methods "PUT, GET, POST, DELETE, OPTIONS"
      }
    }
  }
}

when HTTP_RESPONSE {
  if {$rest_flag} {
    HTTP::header replace Access-Control-Allow-Origin: "https://honeyb.io"
    HTTP::header replace Access-Control-Allow-Headers "origin, x-requested-with, content-type, Authorization"
    HTTP::header replace Access-Control-Allow-Methods "PUT, GET, POST, DELETE, OPTIONS"
  }
}
```
               
If you're still having issues, take a look at our CORS with Self Signed Certificate article, contact us, or consider using our honeyb.io BIG-IP managment suite, which runs on your own virtual infrastructure, and uses its application server to send requests to your BIG-IPs and is not limited by the CORS implementation of your browser.
