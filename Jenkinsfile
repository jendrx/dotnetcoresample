pipeline {
   agent any
   
   stages {
      stage('build'){
        steps{
          echo 'Building'
          sh "docker build --target build --tag dotnetbuild --file Board/Dockerfile ."
        }
      }
      stage('test'){
        steps{
          echo 'Testing'
          sh "docker build --target unittest --tag dotnettest --file Board/Dockerfile ."
          sh "docker run dotnettest dotnet test"
        }
      }
   }
}