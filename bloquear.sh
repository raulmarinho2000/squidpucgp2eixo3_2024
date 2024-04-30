#!/bin/bash
if [ "$2" == "adicionar" ]; then
  echo $1 >> /var/lib/squidguard/db/hep/block_domain
elif [ "$2" == "remover" ]; then
  sed -i "/$1/d" /var/lib/squidguard/db/hep/block_domain
fi
