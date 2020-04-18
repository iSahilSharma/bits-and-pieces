# Docker

Docker - 
To build the docker images
*docker image build -tag "specify a tag such as sampleimage:v1" --no-cache .*
 *docker build -t "specify a tag such as sampleimage:v1" -f "specify docker file such as Dockerfile.debug"*
 
To run the docker container
*docker container run --detach --publish "8080:80" --name "sample-container" "image-name"*
*docker run -d -p "8080:80" --name "sample-container" "image-name"*

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
To see if docker swarm is enabled or not:
*docker info*
Execute it and see the swarm key-value pair, either it is active or inactive.

To enable the docker swarm mode:
*docker swarm init --advertise-addr 192.168.99.100"*

To see the docker nodes:
*docker node ls"*

To inspect the docker node:
*docker node inspect self"*
*docker node inspect "node-id"*

To create a container(service) in docker-swarm mode:
*docker service create --name "service-name" -p "8080:80" nginx*

To remove a container(service) in docker-swarm mode:
*docker service rm "service-name"*

To view specific container(service) in docker-swarm mode:
*docker service ps "service-name"*

To view all containers(services) in docker-swarm mode:
*docker service ls*

To update the container(service) in docker-swarm mode:
*docker service update --replicas=2 "service-name"*

To scale the container(service) in docker-swarm mode:
*docker service scale "service-name"="number"*
