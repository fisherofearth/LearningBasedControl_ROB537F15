function [ V , rec_CR] = Task1( V0, steps, epsilon, alpha, episode)
%TASK1 Summary of this function goes here
%   Detailed explanation goes here

mean = [1;1.5;2;2;1.75];
sigm = [5;1  ;1;2;10];
V = V0;
for i = 1: 5
    V(i) = V(i) +rand;
end

for i = 1 : episode
%     action = zeros(timeSteps,1);
    r = zeros(steps,5);
    for ts = 1 : steps
         a= PickAction( V, epsilon );
         r(ts,a) = normrnd(mean(a,1),sigm(a,1));
%          action(ts,1) = a;
    end
    
    
    ra = [];
    for act = 1 : 5
        ra(act) = sum(r(:,act)) / size(find(r(:,act)~=0),1);
    end
%     [R idx] =max(sum(r)'/steps);
    [R idx] =max(ra);
    rec_CR(i,1) = sum(sum(r))/steps;
    K = size(find(r(:,idx)~=0),1);
    if(K~= 0)
        R = R/K;
        V(idx) = V(idx) + (alpha * (R - V(idx)));
        
    else
        i = i-1;
    end
end

end
