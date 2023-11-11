# Bits and pieces of code
> Curated collection of code snippets and solutions: a repository where you'll find the building blocks and handy fragments that make up the diverse landscape of coding. From time-saving tricks to essential functions, this repository is a treasure trove of bits and pieces that simplify your daily coding adventures. Explore a versatile collection of code fragments, essential snippets, Docker configurations, SQL commands, and handy helper methods curated to elevate the efficiency of your projects.

# Docker
 
To build a docker image:
```
docker image build -tag "specify a tag name as image:v1" --no-cache . 

docker build -t "specify a tag name as image:v1" -f "specify docker file as Dockerfile.debug" 
```
 
To run a docker container:
```
docker container run --detach --publish "8080:80" --name "sample-container" "image-name"

docker run -d -p "8080:80" --name "sample-container" "image-name"

docker run -it --rm -p 8080:80 "appname:version"
```

To check the details about Docker Engine installed on the machine:
```
docker version

docker info

where docker
```

To check the statistics of containers:
```
docker stats
```

To remove a container from docker engine:
```
docker rm -f "container name or id"
```

To remove images from docker engine:
```
docker rmi -f "image name or id"
```

To see all the containers:
```
docker container ls -a"

docker ps -a"
```

To see all the images:
```
docker image ls -a"

docker images -a"
```

To remove all the unused container and images:
```
docker system prune -f -a"
```

To create or inspect a network:
```
docker network create "network-name"

docker network inspect "network-name"
```

To check the docker logs:
```
docker logs "container-name"
```

# Docker Compose
 
To execute the docker compose files:
```
docker-compose build

docker-compose -f docker-compose.yml up -d

docker-compose -f docker-compose.yml up -d --scale containername=5

docker-compose -f docker-compose.yml down
```

To start the docker container:
```
docker-compose start "container-name" -d
```

To stop the docker container:
```
docker-compose stop "container-name"
```

To add the docker container:
```
docker-compose up "container-name" -d
```

To remove the docker container:
```
docker-compose down "container-name"
```

To check the docker logs:
```
docker-compose logs "container-name"
```

To check the docker processes:
```
docker-compose top "container-name"
```

# Docker Swarm

To see if docker swarm is enabled or not. Execute it and see the swarm key-value pair, either it is active or inactive:
```
docker info
```

To enable the docker swarm mode:
```
docker swarm init --advertise-addr 192.168.99.100"
```

To see the docker nodes:
```
docker node ls"
```

To inspect the docker node:
```
docker node inspect self"

docker node inspect "node-id"
```

To create a container(service) in docker-swarm mode:
```
docker service create --name "service-name" -p "8080:80" nginx
```

To remove a container(service) in docker-swarm mode:
```
docker service rm "service-name"
```

To view specific container(service) in docker-swarm mode:
```
docker service ps "service-name"
```

To view all containers(services) in docker-swarm mode:
```
docker service ls
```

To update the container(service) in docker-swarm mode:
```
docker service update --replicas=2 "service-name"
```

To scale the container(service) in docker-swarm mode:
```
docker service scale "service-name"="number"
```

To build the container(service) in docker-swarm mode using docker-stack file:
```
docker stack deploy -c docker-stack.yml "service-name"
```

# REST 

## Method Safety and Method Idempotency:
A method is considered safe when it doesn't change the resource representation. 
A method is considered idempotent when it can be called multiple times with the same result. In simple terms, a method is idempotent when performing certain operations cam be applied multiple times without changing the result.

<table>
<tr>
<th>HTTP Method</th>
<th>Safe</th>
<th>Idempotent</th>
</tr>
<tr>
<td>GET</td>
<td>yes</td>
<td>yes</td>
</tr>
<tr>
<td>OPTIONS</td>
<td>yes</td>
<td>yes</td>
</tr>
<tr>
<td>HEAD</td>
<td>yes</td>
<td>yes</td>
</tr>
<tr>
<td>POST</td>
<td>no</td>
<td>no</td>
</tr>
<tr>
<td>DELETE</td>
<td>no</td>
<td>yes</td>
</tr>
<tr>
<td>PUT</td>
<td>no</td>
<td>yes</td>
</tr>
<tr>
<td>PATCH</td>
<td>no</td>
<td>no</td>
</tr>
</table>

# Software Architecture 

## Three Layer Architecture:
A

## Clean Architecture:
A
