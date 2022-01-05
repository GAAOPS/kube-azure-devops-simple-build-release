# get your master url
kubectl config view --minify -o jsonpath={.clusters[0].cluster.server}

kubectl get serviceAccounts devops-service-user -n vsts -o=jsonpath={.secrets[*].name}

kubectl get secret <service-account-secret-name> -n vsts -o json