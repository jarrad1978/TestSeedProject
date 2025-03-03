docker network create testseedproject --label=testseedproject
docker-compose -f docker-compose.infrastructure.yml up -d
exit $LASTEXITCODE