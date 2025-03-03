#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p f597bf03-5133-410a-86e5-9f071dd55e58 -t
    fi
    cd ../
fi

docker-compose up -d
