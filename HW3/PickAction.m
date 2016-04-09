function [ actionIdx ] = PickAction( prob_action, epsilon )
%PICKACTION Summary of this function goes here
%   Detailed explanation goes here

    neg = find(prob_action<0);
    if(neg>0)   %if contain negative number
        prob_action(neg) = 0;
%         prob_action = prob_action - min(prob_action);
    end
    
    if(sum(prob_action - prob_action(1)) == 0)
        for i = 1 :length(prob_action)
            prob_action(i) = prob_action(i) + rand;
        end
    end
    
    if(epsilon ~= 0) 
        % apply epsilon greedy
        [maxValue idx] = max(prob_action);
        if(rand < epsilon)
            idx = find(prob_action ~= maxValue);
        else
            idx = find(prob_action==maxValue);
        end
    else
        % apply greedy
        [maxValue idx] = max(prob_action);
        idx = find(prob_action==maxValue);
    end
    
    uniformDist = ones(size(idx,1),1);
    uniformDist = uniformDist/ norm(uniformDist,1);% Normalization
    actionIdx = idx(find(rand<cumsum(uniformDist),1,'first')); 
    
%     if(actionIdx > 0)
%         
%     else
%         uniformDist = ones(size(prob_action,1),1);
%         uniformDist = uniformDist/ norm(uniformDist,1);% Normalization
%         actionIdx = find(rand<cumsum(uniformDist),1,'first'); 
%     end
end

%     prob_action = prob_action/ norm(prob_action,1);% Normalization
%         actionIdx = find(rand<cumsum(prob_action),1,'first');    