pipeline {
   agent any
   
   stages {
      stage('build'){
        steps{
          echo 'Building'
          docker build --target build --tag dotnetbuild --file Board/Dockerfile .
        }
      }
      stage('test'){
        steps{
          echo 'Testing'
          docker build --target unittest --tag dotnettest --file Board/Dockerfile .
        }
      }
   }
}