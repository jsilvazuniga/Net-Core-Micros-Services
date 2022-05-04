# .Net Core using Micros Services
.Net Service example


- .Net Core 6.0
- Docker
	PmatformService
	docker build -t <your docker hub id>/platformservice .
	docker run -p 8080:80 -d <your docker hub id>/platformservice
	docker ps
	docker stop <container id>
	docker start <container id>
	docker push <your docker hub id>/platformservice
	
	Examples:
	- docker build -t jsilvazuniga/platformservice .
	- docker run -p 8080:80 -d jsilvazuniga/platformservice
	- docker push jsilvazuniga/platformservice
	- Test: 
		- http://localhost:8080/api/platforms
		
		

- Kubernetes
		kubectl apply -f platforms-depl.yaml
		kubectl get deployments
		kubectl get pods