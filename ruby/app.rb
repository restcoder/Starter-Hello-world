require 'sinatra'
require 'json'

set :bind, '0.0.0.0'
set :port, ENV['PORT']

get '/hello' do
'world'
end

get '/hello-json' do
  content_type :json
  { :hello => 'world' }.to_json
end

Thread.new do
  sleep 1
  print 'READY'
  STDOUT.flush
end
