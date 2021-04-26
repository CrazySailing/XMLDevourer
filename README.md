# XMLDevourer

## Aim
This project aims to implement an XML reader that prints basic information on the XML file. The project should be implemented with the best CI/CD setup possible and will explore the workings of GitHub actions (through automatic builds and test) and Docker deployment. Also used as a tutorial to GitHub and it's features.


## Installation
This project uses Docker as the recomended running enviroment. Provided in `Dockerfile` is a Docker definition of a C# SDK enviroment with usefull functionallity. To develop the project, use the setup below.

1. Pull the repo to a suitable location on your computer.
2. Make sure you have docker installed on your computer (more info: [Get Docker](https://docs.docker.com/get-docker/)).

### Via CLI
3. Build the Docker image by navigating to the Repo's root folder and run `docker build -t xmldevourer:dev -f Dockerfile .`
4. Run the container and mount your code into the container by running `docker run -it --mount type=bind,source="$(pwd)",target=/app xmldevourer:dev`

### Using VSCode

3. Install _Remote Development_ and _Docker_ extentions.
4. Open the remote menu. Choose _Add Remote Development Configuration Files_. Add the following to the `.devcontainer/devcontainer.json`:
``` jsonc
{
	"name": "Existing Dockerfile",

	// Sets the run context to one level up instead of the .devcontainer folder.
	"context": "..",

	// Update the 'dockerFile' property if you aren't using the standard 'Dockerfile' filename.
	"dockerFile": "../Dockerfile",

	// Set *default* container specific settings.json values on container create.
	"settings": { 
		"terminal.integrated.shell.linux": null
	},

	// Add the IDs of extensions you want installed when the container is created.
	"extensions": [], 

    // Changes mountpoint of the folder
	"workspaceMount": "source=${localWorkspaceFolder},target=/app,type=bind,consistency=cached",
	"workspaceFolder": "/app"
}
```

5. Open the remote menu. Choose _Reopen in Container_.
6. Develop! :champagne: :tada:


### Using other IDE
Different IDE's work differently. The important part is just that your IDE uses the correct Docker image/Dockerfile and mounts your code through a bind mount to /app in the container.