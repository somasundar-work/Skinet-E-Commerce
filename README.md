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

This command disables the Angular CLI analytics feature globally for all projects on your machine.
By running this command, you ensure that no usage data is sent to the Angular team, enhancing your privacy.

### Command

```sh
ng config -g cli.analytics false
```

### Explanation

- `ng config`: This is the Angular CLI command used to set or retrieve configuration values.
- `-g`: This flag indicates that the configuration change should be applied globally, affecting all Angular projects on your machine.
- `cli.analytics`: This is the specific configuration key that controls the analytics feature.
- `false`: This value disables the analytics feature.
  \*/
  
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
