%% ROB 537 Homework 1 
%   - auther: Xi Yu
%   - date: 09-30-2015

%% Parameters:
data = train2;

num_hidenLayer = 15; % choose different number of hiden layer nodes 
learningRate = 0.1;
trainingTime = 5000;

rec_time = zeros(5,1);

% num_hidenLayer = [5;10;15;20;50];
% learningRate = [0.5;0.1;0.01];
%  for   p = 1 :1
%     tic
    [rec_MSE, w_ji, w_j, w_jk, w_k ] = NNA1( data, learningRate, trainingTime, num_hidenLayer, 0.00001);
%     rec_time(p,1) = toc
%  end


MSE = [];
Error = [];


 for   p = 1 : 3
    MSE(:,p) = rec_MSE(:,1,p)
    Error(:,p) = rec_MSE(:,2,p)
 end
 
close all

tmp = Error;
tmp = tmp / 200;
for p = 1: 3
    tmp(:,p) = smooth(tmp(:,p),50)
end
plot(tmp)

plot(rec_MSE) 

%% Testing

 [ MSEl error ] = Test( test3, w_ji, w_j, w_jk, w_k )

 error = error/200



















