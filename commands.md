# Some Important commands


## React
### create new file
* `New-Item -Path "filename here" -ItemType File` eg `New-Item -Path "board.tsx" -ItemType File`
* 
### create new react application
* `npx create-react-app MyFiirstReactApp `
*  to run the app ` npm start `
## .net
### create new .net console app
* first create a folder with Project name and run this command inside that folder path
`dotnet new console --framework net7.0`
* to run the app `dotnet run `
* for command help run `dotnet new console -h `
## Competative Programming
## Docker
*  docker ps [options]
*  # options are
*  -a, --all: Show all containers, including those that are stopped.
*  -q, --quiet: Only display container IDs. 
*  --no-trunc: Display the full command in the output.
  
* docker images : show all images exist on docker
* docker logs : show all logs
*  docker logs [container id] eg-   docker logs 3a204dba74b7
*  docker build -t node-app:1.0 . (run this command where doscker file is there and it will build image as node-app with tag 1.0 )
*  docker run -d -p 3000:3000  node-app:1.0 (run build image on port)
*  docker stop [container id]  eg -  docker stop 3a204dba74b7
* 