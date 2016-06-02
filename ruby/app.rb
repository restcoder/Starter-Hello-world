require 'sinatra'

set :bind, '0.0.0.0'

get '/hello' do
  "world"
end

# there is no callback for sinatra startup
# wait 1s and print READY
Thread.new do
  sleep 1
  STDOUT.puts 'READY'
  STDOUT.flush
end