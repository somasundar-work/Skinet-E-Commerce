# Skinet

Skinet is an e-commerce application built using .NET Core. It provides a robust platform for managing products, orders, and users. The application is designed with a clean architecture, ensuring separation of concerns and scalability.

## Code Formatting with CSharpier

This project utilizes **CSharpier**, an opinionated code formatter for C#. CSharpier ensures that the codebase maintains a consistent coding style by automatically formatting the code according to its predefined rules. This helps improve code readability and maintainability, making it easier for developers to collaborate on the project.

### [CSharpier Official Docs](https://csharpier.com/docs/About)

### How to Use CSharpier

To use CSharpier, follow these steps:

1. Install CSharpier as a global tool using the following command:
   ```sh
   dotnet tool install -g csharpier
   ```
2. Run CSharpier on your code files by executing:
   ```sh
   csharpier .
   ```
   This command will format all the C# files in the current directory and its subdirectories.

By integrating CSharpier into your workflow, you can ensure that your code remains clean and consistent throughout the development process.

## Disable Angular CLI Analytics

This command disables the Angular CLI analytics feature globally for all projects on your machine. By running this command, you ensure that no usage data is sent to the Angular team, enhancing your privacy.

### Command

```sh
ng config -g cli.analytics false
```

### Explanation

- `ng config`: This is the Angular CLI command used to set or retrieve configuration values.
- `-g`: This flag indicates that the configuration change should be applied globally, affecting all Angular projects on your machine.
- `cli.analytics`: This is the specific configuration key that controls the analytics feature.
- `false`: This value disables the analytics feature.

# Client

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 19.0.6.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

Angular CLI includes powerful code scaffolding tools. To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Karma](https://karma-runner.github.io) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.

# mkcert

[Github URL](https://github.com/FiloSottile/mkcert)

mkcert is a simple tool for making locally-trusted development certificates. It requires no configuration.

```
$ mkcert -install
Created a new local CA 💥
The local CA is now installed in the system trust store! ⚡️
The local CA is now installed in the Firefox trust store (requires browser restart)! 🦊

$ mkcert example.com "*.example.com" example.test localhost 127.0.0.1 ::1

Created a new certificate valid for the following names 📜
 - "example.com"
 - "*.example.com"
 - "example.test"
 - "localhost"
 - "127.0.0.1"
 - "::1"

The certificate is at "./example.com+5.pem" and the key at "./example.com+5-key.pem" ✅
```

<p align="center"><img width="498" alt="Chrome and Firefox screenshot" src="https://user-images.githubusercontent.com/1225294/51066373-96d4aa80-15be-11e9-91e2-f4e44a3a4458.png"></p>

Using certificates from real certificate authorities (CAs) for development can be dangerous or impossible (for hosts like `example.test`, `localhost` or `127.0.0.1`), but self-signed certificates cause trust errors. Managing your own CA is the best solution, but usually involves arcane commands, specialized knowledge and manual steps.

mkcert automatically creates and installs a local CA in the system root store, and generates locally-trusted certificates. mkcert does not automatically configure servers to use the certificates, though, that's up to you.

## Configuring SSL in an Angular Application

Follow these steps to configure SSL in your Angular application:

1. **Generate SSL Certificates:**

   - Use a tool like `mkcert` to generate a self-signed certificate.
   - Example command:
     ```sh
     mkcert -install
     mkcert localhost
     ```
   - This will generate `localhost.pem` and `localhost-key.pem` files.

2. **Update Angular Configuration:**

   - Open `angular.json` and locate the `serve` options for your project.
   - Add the following SSL configuration:
     ```json
     "options": {
       "ssl": true,
       "sslKey": "path/to/localhost-key.pem",
       "sslCert": "path/to/localhost.pem"
     }
     ```

3. **Serve the Application with SSL:**

   - Use the Angular CLI to serve your application with SSL enabled.
   - Example command:
     ```sh
     ng serve --ssl --ssl-key path/to/localhost-key.pem --ssl-cert path/to/localhost.pem
     ```

4. **Access the Application:**
   - Open your browser and navigate to `https://localhost:4200`.
   - You should see your Angular application served over HTTPS.

## Notes

- For production environments, use certificates issued by a trusted Certificate Authority (CA).
- Ensure that your server configuration (e.g., Nginx, Apache) is also set up to handle SSL if deploying to a web server.
