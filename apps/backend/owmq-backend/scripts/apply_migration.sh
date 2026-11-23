#!/bin/bash
set -euo pipefail
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_PATH="$SCRIPT_DIR/.."
ENV_PATH="$PROJECT_PATH/../.env"

#ensure .env exists
if [ ! -f "$ENV_PATH" ]; then
	echo "ERROR: Couldn't find .env file $ENV_PATH" >& 2
	exit 1
fi

#ensure migration name argument exists
if [ $# -lt 1 ]; then
	echo "Usage: $0 <migration_name>" >& 2
	exit 1
fi
MIGRATION_NAME="$1"

set -a
source "$ENV_PATH"
set +a

cd $PROJECT_PATH

dotnet ef migrations add $MIGRATION_NAME
dotnet ef database update --connection "Host=localhost;Port=$POSTGRES_PORT;Database=$POSTGRES_DB;Username=$POSTGRES_USER;Password=$POSTGRES_PASSWORD"
