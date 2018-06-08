# Redis-cache

1. Download the redis-latest.zip native 64bit Windows port of redis
wget https://github.com/ServiceStack/redis-windows/raw/master/downloads/redis-latest.zip
2. Extract redis64-latest.zip in any folder, e.g. in c:\redis
3. Run the redis-server.exe using the local configuration
cd c:\redis
redis-server.exe redis.windows.conf
4. Run redis-cli.exe to connect to your redis instance
cd c:\redis
redis-cli.exe
5. Start playing with redis :)
redis 127.0.0.1:6379> SET foo bar
OK
redis 127.0.0.1:6379> KEYS *
1) "foo"
redis 127.0.0.1:6379> GET foo
"bar"
redis 127.0.0.1:6379>

Reference : https://github.com/ServiceStack/redis-windows
