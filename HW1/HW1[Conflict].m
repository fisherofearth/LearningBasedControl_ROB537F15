%% ROB 537 Homework 1 
%   - auther: Xi Yu
%   - date: 09-30-2015

%% Parameters:
data = train1;

num_hidenLayer = 10; % choose different number of hiden layer nodes 
learningRate = 0.1;
trainingTime = 6000;

rec_time = zeros(5,1);

num_hidenLayer = [5;;10;15;20;50];

    p = 5
    tic
    [ rec_MSE5, w_ji, w_j, w_jk, w_k ] = NNA1( data, learningRate, trainingTime, num_hidenLayer(p,1), 0.001);
    rec_time(p,1) = toc


plot((rec_MSE5))


plot(rec_MSE5(:,1))
plot(smooth(rec_MSE5(:,1),'loess'))

MSE = [];
Error = [];


    p= 5;
    MSE(:,p) = rec_MSE5(:,1)
    Error(:,p) = rec_MSE5(:,2)

tmp = MSE;   
for p = 1: 5
    tmp(:,p) = smooth(tmp(:,p),50);
end
plot(tmp)


%% Testing
 [ MSEl error ] = Test( test3, w_ji, w_j, w_jk, w_k );

tic 
