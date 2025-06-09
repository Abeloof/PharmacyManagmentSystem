Objective
	manage patient prescriptions in a pharmacy management system. goal is to create an API that allows for:Adding a new prescription & Retrieving a prescription by patient ID
	Angular component to display and add prescriptions for a given Patient ID

TODO
	docker compose configuration needs to be complete
        project builds in a dev environment

To run, VS code is suggested with devcontainers (requires docker-compose & devcontainer plugin for vscode)
    Server (dotnet core)
	git checkout {{repo}}
	cd server code .
        reopen solution in dev containers
	run C# project (http)

    UI (angular) - from another terminal
	cd UI
	ng serve
