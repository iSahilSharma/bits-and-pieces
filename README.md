# Useful Programming Commands

### Docker

Docker Commands - 

Docker Build:
It is used to build the docker images
 *docker build -t "specify a tag such as sampleimage:v1" -f "specify docker file such as Dockerfile.debug"*

Docker Run:
It is used to run the docker container
*docker run -d -p "8080:80" --name "sample-container"*

Docker Info:
It is used to see the details about docker engine installed in the machine.
*docker info*

Docker Stats:
It is used to show the statistics of containers like the task manager
*docker stats*

Docker rm:
It is used to remove containers from docker engine.
*docker rm -f "container name or id"*

Docker rmi:
It is used to remove images from docker engine.
*docker rmi -f "image name or id"*

Docker ps:
It is used to see all the containers.
*docker ps -a"*

Docker images:
It is used to see all the images.
*docker images -a"*

Docker prune:
It is used to remove the unsed container and images.
*docker system prune -f -a"*

Docker network:
It is used to create or inspect a network.
*docker network create "network-name"*
*docker network inspect "network-name"*
