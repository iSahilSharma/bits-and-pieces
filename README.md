# Useful Commands

### Docker

Docker - 
To build the docker images
 *docker build -t "specify a tag such as sampleimage:v1" -f "specify docker file such as Dockerfile.debug"*

To run the docker container
*docker run -d -p "8080:80" --name "sample-container"*

To see the details about docker engine installed in the machine.
*docker info*

To show the statistics of containers like the task manager
*docker stats*

To remove containers from docker engine.
*docker rm -f "container name or id"*

To remove images from docker engine.
*docker rmi -f "image name or id"*

To see all the containers.
*docker container ls -a"*
*docker ps -a"*

To see all the images.
*docker image ls -a"*
*docker images -a"*

To remove the unsed container and images.
*docker system prune -f -a"*

To create or inspect a network.
*docker network create "network-name"*
*docker network inspect "network-name"*


Docker Compose -
To execute the docker compose files.
*docker-compose build*
*docker-compose up*
*docker-compose down*
*docker-compose -f docker-compose.yml up -d*
*docker-compose -f docker-compose.yml down*

Docker Swarm:
To see if the swarm is enabled or not:
*docker info*
Execute it and see the swarm key-value pair, either it is active or inactive.

To enable the swarm mode:
*docker swarm init --advertise-addr 192.168.99.100"*

To see the docker swarm nodes:
*docker node ls"*

