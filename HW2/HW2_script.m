%% ROB 537 F15 - Homework 2
%% Author: Xi Yu 'Fisher
%% Date: 10/22/2015

%% import data
filename = '25cities_A.csv';
data = csvread(filename);
num_city = data(1);
data = data(2:end,:);
clearvars filename

%% Compute the city to city distance matrix (dist_C2C)
dist_C2C = [];
for c1 = 1 : num_city
    for c2 = 1 : num_city
        dist_C2C(c1,c2) = norm(data(c1,:) - data(c2,:));
    end
end
clearvars c1 c2


%% Task 1
% --- Simulated annealing
limit = 10000;
scale = 0.001; % 0< scale <.5
for i = 1 : 10
[optimalPath, rec_temperature, computationTime ] = SimulatedAnnealing(dist_C2C, num_city, scale, limit );
out_runtime(i) = computationTime;
out_length(i) = min(rec_temperature);
out_path(:,i) = optimalPath;
end
plot(out_runtime(2:end))
plot(smooth(rec_temperature,50));
out_cost(1,:) = rec_temperature;

% --- Evolutionary algorithm
limit = 10000;
K = 4;
for i = 1 : 10
[ optimalPath, rec_minCost, computationTime ] = Evolutionary( dist_C2C, num_city, limit, K );
out_runtime(i) = computationTime;
out_length(i) = min(rec_minCost);
out_path(:,i) = optimalPath;
end

% --- Stochastic Beam Search
limit = 200;
K = 4;
for i = 1 : 10
[ optimalPath, rec_minCost, computationTime ] = SBeamSearch( dist_C2C, num_city, limit, K );
out_runtime(i) = computationTime;
out_length(i) = min(rec_minCost);
out_path(:,i) = optimalPath;
end

%%
% figure
% hold off;
% X = [];
% Y = [];
% for i = 1: num_city
%     idx1 = optimalPath(i);
%     idx2 = optimalPath(i + 1);
%     X(1, i) = data(idx1,1);
%     X(2, i) = data(idx2,1);
%     Y(1, i) = data(idx1,2);
%     Y(2, i) = data(idx2,2);
% end
% scatter(data(:,1),data(:,2));
% hold on;
% plot(X, Y);
% clearvars idx X Y


%% note:
% 	num_    number_
%   dist_   distance_
%   rec_    record_


