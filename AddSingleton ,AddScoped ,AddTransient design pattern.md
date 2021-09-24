# AddSingleton ,AddScoped ,AddTransient

## AddSingleton:
- With Singleton service there is only single instance.
- An instance is created,when the service is first requested and single instance is used by all http requests throughout the application.

## AddScoped
- With a Scoped service we get the same instance within the scope of a given http request but new instance across different http requests.

## AddTransient
- With a Transient service a new  instance is provided every time an instance is requested whether it is in the scope of the same http request
or across different http request.
