function [ V, rec ] = Task2(epsilon, alpha, episode )
%TASK2 Summary of this function goes here
%   Detailed explanation goes here

steps = 20;
mapSize = [10; 5]; 
goalS = [10;4];
rtf = [1;0];
upf = [0;-1];
ltf = [-1;0];   
dnf = [0;1];
stay = [0;0];
A = [rtf upf ltf dnf stay];
X = 1;
Y = 2;

% initial V table (xD, yD, actionD)
V = ones(mapSize(Y), mapSize(X),  length(A)) * 50; 
for x = 1 : mapSize(X)
    for y = 1 : mapSize(Y)
        for a  = 1 : length(A)
            V(y,x,a) = V(y,x,a) + rand;
        end
    end
end
V(:,mapSize(X),1) = 0;%right
V(1,:,2) = 0; %up
V(:,1,3) = 0; %left
V(mapSize(Y),:,4) = 0;%down


% rec_step = [];
for learn = 1 : episode
    S = [randi(mapSize(X));randi(mapSize(Y))]; % initital state [x; y]
    
    rec(learn,1) = 0;
    for st = 1: steps
        prob_action = [V(S(Y),S(X),1); V(S(Y),S(X),2); V(S(Y),S(X),3); V(S(Y),S(X),4); V(S(Y),S(X),5)]; % construct action probability vector     
        
        verify = -1;
        while(verify<0)
            a = PickAction(prob_action, epsilon); % Pick an action based on the probability of actions
            verify = Constrain( S, A(:,a), mapSize ); % verify if state+action is illegal(in-map)
            %prob_action(a) = 0; %remove this action because it is illegal
        end
        
        newS = S + A(:,a);
        
        
         V(S(Y),S(X),a) = V(S(Y),S(X),a) + alpha * (100-(sum(abs(newS-goalS))) - V(S(Y),S(X),a));
%        V(S(Y),S(X),a) = V(S(Y),S(X),a) + alpha * (100-(st) - V(S(Y),S(X),a));
        if(V(S(Y),S(X),a)<1)
            V(S(Y),S(X),a) =rand ;
        end
        
        rec(learn,1) = -st/(sum(abs(newS-goalS))+1);
        S = newS; % update current state
        if(S ==goalS)
            st = steps;
            rec(learn,1) = (100-st)/(sum(abs(newS-goalS))+1);
        end
        
    end
%     rec_step(learn) = R;
end

end

